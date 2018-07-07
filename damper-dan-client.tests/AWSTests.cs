using System;
using System.Linq;
using System.Collections.Generic;
using damper_dan_client.Controllers;
using DamperDB;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Xunit;

using damper_dan_client.Interfaces;

namespace damper_dan_client.tests
{
    public class AWSTests
    {
		[Fact]
        // dotnet test --filter "FullyQualifiedName=damper_dan_client.tests.AWSTests.UploadToS3Bucket"
        public void UploadToS3Bucket()
        {
            Console.WriteLine("UploadToS3Bucket");
        }
    }
}
