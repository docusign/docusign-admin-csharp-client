using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocuSign.Admin.Model;
using DocuSign.Admin.Client;
using DocuSign.Admin.Api;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using DocuSign.Admin.Client.Auth;
using System.Text;
using System.Linq;

namespace SdkTests462
{
    [TestClass]
    public class JwtAuthUnitTests
    {
        TestConfig testConfig = new TestConfig();

        [TestInitialize()]
        [TestMethod]
        public void JwtLoginTest()
        {
            testConfig.ApiClient = new ApiClient(testConfig.Host);

            Assert.IsNotNull(testConfig.PrivateKey);

            byte[] privateKeyStream = Convert.FromBase64String(testConfig.PrivateKey);

            List<string> scopes = new List<string>() { "signature", "organization_read", "user_read", "user_write" };

            OAuth.OAuthToken tokenInfo = testConfig.ApiClient.RequestJWTUserToken(testConfig.IntegratorKey, testConfig.UserId, testConfig.OAuthBasePath, privateKeyStream, testConfig.ExpiresInHours, scopes);
            // Disposing the stream...

            // the authentication api uses the apiClient (and X-DocuSign-Authentication header) that are set in Configuration object
            OAuth.UserInfo userInfo = testConfig.ApiClient.GetUserInfo(tokenInfo.access_token);
            Assert.IsNotNull(userInfo);
            Assert.IsNotNull(userInfo.Accounts);
            testConfig.AccountId = userInfo.Accounts.FirstOrDefault().AccountId;
            Assert.IsNotNull(testConfig.AccountId);
            GetOrgsTest();
        }

        [TestMethod]
        public void GetOrgsTest()
        {
            var acc = new AccountsApi(testConfig.ApiClient);
            var orgs = acc.GetOrganizations();
            Assert.IsNotNull(orgs);
            Assert.IsNotNull(orgs.Organizations);
            testConfig.OrgId = orgs.Organizations.FirstOrDefault().Id;
        }

        [TestMethod]
        public void CreateBulkImportAddUsersRequestTest()
        {
            GetOrgsTest();
            var bulkImportApi = new BulkImportsApi(testConfig.ApiClient);
            var csvFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "docs", "organization-user-import.csv");
            var str = File.ReadAllText(csvFile);
            str = str.Replace("<accountId>", testConfig.AccountId);
            File.WriteAllText(csvFile, str);

            var res = bulkImportApi.CreateBulkImportAddUsersRequest(testConfig.OrgId, File.ReadAllBytes(csvFile));

            Assert.IsNotNull(res);
        }

        [TestMethod]
        public void CreateUserTest()
        {
            var usersApi = new UsersApi(testConfig.ApiClient);
            var permissionProfile = new DocuSign.Admin.Model.PermissionProfileRequest();
            permissionProfile.Id = testConfig.PermissionProfileId;
            var accountProps = new NewUserRequestAccountProperties();
            accountProps.Id = Guid.Parse(testConfig.AccountId);
            accountProps.PermissionProfile = permissionProfile;
            accountProps.Groups = new List<GroupRequest>();
            var request = new NewUserRequest();
            request.UserName = "testuser";
            request.Email = "xxx@yyy.zzz";
            var accountsList = new List<NewUserRequestAccountProperties>();
            accountsList.Add(accountProps);
            request.Accounts = accountsList;
            var response = usersApi.CreateUser(testConfig.OrgId, request);
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void GetProductPermissionProfilesTest()
        {
            var permProfileApi = new ProductPermissionProfilesApi(testConfig.ApiClient);
            var res = permProfileApi.GetProductPermissionProfiles(testConfig.OrgId, Guid.Parse(testConfig.AccountId));
            Assert.IsNotNull(res);
            Assert.IsNotNull(res.ProductPermissionProfiles);
            Assert.IsNotNull(res.ProductPermissionProfiles.FirstOrDefault());
            Assert.IsNotNull(res.ProductPermissionProfiles.FirstOrDefault().PermissionProfiles);
            Assert.IsNotNull(res.ProductPermissionProfiles.FirstOrDefault().PermissionProfiles.FirstOrDefault());
            Assert.IsNotNull(res.ProductPermissionProfiles.FirstOrDefault().PermissionProfiles.FirstOrDefault().PermissionProfileId);
        }

        [TestMethod]
        public void GetUserProfilesTest()
        {
            var usersApi = new UsersApi(testConfig.ApiClient);
            var options = new UsersApi.GetUsersOptions();
            options.accountId = Guid.Parse(testConfig.AccountId);
            DateTime fromDate = DateTime.UtcNow;
            fromDate = fromDate.AddDays(-10);
            string fromDateStr = fromDate.ToString("o");
            options.lastModifiedSince = fromDateStr;

            var modifiedUsers = usersApi.GetUsers(testConfig.OrgId, options);

            foreach (var user in modifiedUsers.Users)
            {
                var profileOptions = new UsersApi.GetUserProfilesOptions();
                profileOptions.email = user.Email;
                var res = usersApi.GetUserProfiles(testConfig.OrgId, profileOptions);
                Assert.IsNotNull(res);
            }
        }
    }
}
