﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace WebServer.Application.Models
{
    public static class LoginData
    {
	    public static string Result = "Insert your credentials.";

	    public static void SetUp(string username, string password)
	    {
		    Result = $"Hi {username}, your password is {password}";
	    }
	}
}
