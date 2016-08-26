﻿using System;
using Xunit;

namespace System.Tests
{
    public static class TimeZoneNotFoundExceptionTests
    {
        [Fact]
        public static void Ctor_Empty()
        {
            var exception = new TimeZoneNotFoundException();
            Assert.NotNull(exception);
            Assert.NotEmpty(exception.Message);
        }

        [Fact]
        public static void Ctor_String()
        {
            string message = "New TimeZoneNotFoundException";
            var exception = new TimeZoneNotFoundException(message);
            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public static void Ctor_String_Exception()
        {
            string message = "Created StackOverflowException";
            var innerException = new Exception("Created inner exception");
            var exception = new TimeZoneNotFoundException(message, innerException);
            Assert.Equal(message, exception.Message);
            Assert.Equal(innerException, exception.InnerException);
            Assert.Equal(innerException.HResult, exception.InnerException.HResult);
        }
    }
}
