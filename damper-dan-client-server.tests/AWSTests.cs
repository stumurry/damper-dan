using System;
using System.Collections.Generic;
using System.Linq;
using Amazon;
using Amazon.Runtime.CredentialManagement;
using damper_dan_client.Controllers;
using damper_dan_client.Interfaces;
using DamperDB;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Xunit;

namespace damper_dan_client.tests {
    public class AWSTests {
        [Fact]
        // dotnet test --filter "FullyQualifiedName=damper_dan_client.tests.AWSTests.UploadToS3Bucket"
        public void UploadToS3Bucket () {
            Console.WriteLine ("UploadToS3Bucket");
            var options = new CredentialProfileOptions {
                AccessKey = "AKIAJETN6IOF34SLVHTQ",
                SecretKey = "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"
            };
            var profile = new Amazon.Runtime.CredentialManagement.CredentialProfile ("basic_profile", options);
            profile.Region = RegionEndpoint.USEast1;
            var netSDKFile = new NetSDKCredentialsFile ();
            netSDKFile.RegisterProfile (profile);
        }
    }
}