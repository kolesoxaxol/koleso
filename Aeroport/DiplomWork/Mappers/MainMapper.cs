using AirModel.Models;
using AutoMapper;
using BusinessLogicLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiplomWork.Mappers
{
    public class MainMapper
    {
        public static void MainMappers()
        {
            Mapper.CreateMap<UserViewModel, User>();
           
        }

        public static object Map(object source, Type sourceType, Type destinationType)
        {
            return Mapper.Map(source, sourceType, destinationType);
        }
    }
}