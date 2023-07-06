﻿
using System;
using AutoMapper;
using UsersApi.Data.Dtos;
using UsersApi.Models;

namespace UsersApi.Profiles
{
	public class UserProfile : Profile
	{
		public UserProfile()
		{
			CreateMap<CreateUserDto, User>();
		}
	}
}

