﻿using System;
namespace easyNetAPI.Models.Authentication
{
	public class AuthResponse
	{
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Token { get; set; } = null!;
    }
}
