using Compori.MagentoApi.Authentication;
using Compori.MagentoApi.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Categories;

namespace MagentoApi.BaseUnitTests.Settings
{
    [UnitTest]
    public class LoaderTest
    {
        [Fact]
        public void LoadEmptyTest()
        {
            var result = Loader.Load("Settings/data/settings-loader-1.xml");

            Assert.NotNull(result);
            Assert.Null(result.BaseEndpointAddress);
            Assert.Null(result.UserAgent);

            // Token settings            
            Assert.Equal(TokenType.Undefined, result.Token.TokenType);
            Assert.Null(result.Token.AccessToken);
            Assert.Null(result.Token.BaseEndpointAddress);
            Assert.Null(result.Token.ExpirationPeriod);
            Assert.Null(result.Token.HttpAuthenticationPassword);
            Assert.Null(result.Token.HttpAuthenticationUser);
            Assert.Null(result.Token.RequestPassword);
            Assert.Null(result.Token.RequestUserName);
            Assert.Null(result.Token.UserAgent);

            // Http settings
            Assert.Equal(HttpSettings.DefaultTransportMaxReceivedMessageSize, result.Http.TransportMaxReceivedMessageSize);
            Assert.Equal(HttpSettings.DefaultSendTimeout, result.Http.SendTimeout);

            // Trace settings
            Assert.False(result.Trace.Enable);
            Assert.Null(result.Trace.MessagesFolder);
        }

        [Fact]
        public void TestLoad()
        {
            var result = Loader.Load("Settings/data/settings-loader-2.xml");

            Assert.NotNull(result);
            Assert.Equal("http://www.example.com/shop", result.BaseEndpointAddress);
            Assert.Equal("test", result.UserAgent);

            // Token settings            
            Assert.Equal(TokenType.Admin, result.Token.TokenType);
            Assert.Null(result.Token.AccessToken);
            Assert.Equal(result.BaseEndpointAddress, result.Token.BaseEndpointAddress);
            Assert.Equal(new TimeSpan(1, 23, 45), result.Token.ExpirationPeriod);
            Assert.Equal("http-auth-password", result.Token.HttpAuthenticationPassword);
            Assert.Equal("http-auth-user", result.Token.HttpAuthenticationUser);
            Assert.Equal("my-admin-name", result.Token.RequestUserName);
            Assert.Equal("my-admin-password", result.Token.RequestPassword);
            Assert.Equal(result.UserAgent, result.Token.UserAgent);

            // Http settings
            Assert.Equal(result.UserAgent, result.Http.UserAgent);
            Assert.Equal(10_000_077, result.Http.TransportMaxReceivedMessageSize);
            Assert.Equal(new TimeSpan(0, 0, 30), result.Http.SendTimeout);

            // Trace settings
            Assert.True(result.Trace.Enable);
            Assert.Equal("tempfolder", result.Trace.MessagesFolder);
            
            result = Loader.Load("Settings/data/settings-loader-3.xml");

            Assert.NotNull(result);
            Assert.Equal("http://www.example.com/shop", result.BaseEndpointAddress);
            Assert.Equal("test", result.UserAgent);

            // Token settings            
            Assert.Equal(TokenType.Integration, result.Token.TokenType);
            Assert.Equal(result.BaseEndpointAddress, result.Token.BaseEndpointAddress);
            Assert.Equal("ABC123", result.Token.AccessToken);
            Assert.Equal(result.UserAgent, result.Token.UserAgent);

            // Http settings
            Assert.Equal(result.UserAgent, result.Http.UserAgent);
            Assert.Equal(10_000_077, result.Http.TransportMaxReceivedMessageSize);
            Assert.Equal(new TimeSpan(0, 0, 30), result.Http.SendTimeout);

            // Trace settings
            Assert.True(result.Trace.Enable);
            Assert.Equal("tempfolder", result.Trace.MessagesFolder);
        }

        [Fact]
        public void TestParseBoolean()
        {
            bool defaultValue;
            bool result;

            defaultValue = false;
            result = Loader.ParseBoolean(null, defaultValue);
            Assert.Equal(defaultValue, result);

            defaultValue = true;
            result = Loader.ParseBoolean(null, defaultValue);
            Assert.Equal(defaultValue, result);


            defaultValue = false;
            result = Loader.ParseBoolean("", defaultValue);
            Assert.Equal(defaultValue, result);

            defaultValue = true;
            result = Loader.ParseBoolean("", defaultValue);
            Assert.Equal(defaultValue, result);

            defaultValue = false;
            result = Loader.ParseBoolean("notparsed", defaultValue);
            Assert.Equal(defaultValue, result);
            defaultValue = true;
            result = Loader.ParseBoolean("notparsed", defaultValue);
            Assert.Equal(defaultValue, result);

            //
            // True values
            //
            result = Loader.ParseBoolean("true", false);
            Assert.True(result);
            result = Loader.ParseBoolean("TrUe", false);
            Assert.True(result);
            result = Loader.ParseBoolean("True", false);
            Assert.True(result);
            result = Loader.ParseBoolean("1", false);
            Assert.True(result);
            result = Loader.ParseBoolean("-1", false);
            Assert.True(result);

            //
            // False values
            //
            result = Loader.ParseBoolean("false", true);
            Assert.False(result);
            result = Loader.ParseBoolean("False", true);
            Assert.False(result);
            result = Loader.ParseBoolean("FalsE", true);
            Assert.False(result);
            result = Loader.ParseBoolean("0", true);
            Assert.False(result);
            result = Loader.ParseBoolean("-0", true);
            Assert.False(result);
        }

        [Fact]
        public void TestParseTimeSpan()
        {
            var defaultValue = new TimeSpan(1, 2, 3);
            var result = Loader.ParseTimeSpan(null, defaultValue);
            Assert.Equal(defaultValue, result);
            result = Loader.ParseTimeSpan("", defaultValue);
            Assert.Equal(defaultValue, result);
            result = Loader.ParseTimeSpan("notparsed", defaultValue);
            Assert.Equal(defaultValue, result);

            result = Loader.ParseTimeSpan("0:1:0", defaultValue);
            Assert.Equal(new TimeSpan(0,1,0), result);
            result = Loader.ParseTimeSpan("01:00", defaultValue);
            Assert.Equal(new TimeSpan(1, 0, 0), result);
            result = Loader.ParseTimeSpan("12", defaultValue);
            Assert.Equal(new TimeSpan(12, 0, 0, 0), result);
            result = Loader.ParseTimeSpan("0:1:5.123", defaultValue);
            Assert.Equal(new TimeSpan(0, 0, 1, 5,123), result);
        }

        [Fact]
        public void TestParseInt32()
        {
            int defaultValue;
            int result;
            defaultValue = 1;

            result = Loader.ParseInt32(null, defaultValue);
            Assert.Equal(defaultValue, result);
            result = Loader.ParseInt32("", defaultValue);
            Assert.Equal(defaultValue, result);
            result = Loader.ParseInt32("notparsed", defaultValue);
            Assert.Equal(defaultValue, result);
            result = Loader.ParseInt32("14.000,2", defaultValue);
            Assert.Equal(defaultValue, result);

            result = Loader.ParseInt32("2", defaultValue);
            Assert.Equal(2, result);
            result = Loader.ParseInt32("003  ", defaultValue);
            Assert.Equal(3, result);
            result = Loader.ParseInt32("   12", defaultValue);
            Assert.Equal(12, result);
            result = Loader.ParseInt32("-14", defaultValue);
            Assert.Equal(-14, result);
            result = Loader.ParseInt32("14.000", defaultValue);
            Assert.Equal(14000, result);
        }
    }
}
