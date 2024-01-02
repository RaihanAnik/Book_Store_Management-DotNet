using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService
    {
        public static List<UserDTO> Get()
        {
            var data = DataAccessFactory.UserDataAccess().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<UserDTO>>(data);
            return mapped;
        }
        public static UserDTO Get(string id)
        {
            var data = DataAccessFactory.UserDataAccess().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<UserDTO>(data);
            return mapped;
        }



        public static UserDTO Create(UserDTO user)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<UserDTO, User>();
                c.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(cfg);
            var ht = mapper.Map<User>(user);
            var data = DataAccessFactory.UserDataAccess().Create(ht);


            if (data != null)
                return mapper.Map<UserDTO>(data);
            return null;
        }


        public static UserDTO Update(UserDTO userDTO)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<UserDTO, User>();
                c.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(cfg);
            var user = mapper.Map<User>(userDTO);
            var data = DataAccessFactory.UserDataAccess().Update(user);
            if (data != null)
            {
                return mapper.Map<UserDTO>(data);
            }
            return null;
        }



        public static bool Delete(string id)
        {

            var result = DataAccessFactory.UserDataAccess().Delete(id);
            return result;

        }


        public static ProductDTO GetwithProducts(string id)
        {
            var data = DataAccessFactory.UserDataAccess().Read(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<User, ProductDTO>();
                c.CreateMap<Product,ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ProductDTO>(data);
            return mapped;

        }
    }
}
