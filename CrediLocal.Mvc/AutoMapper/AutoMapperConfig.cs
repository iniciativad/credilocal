using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace CrediLocal.Mvc.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMapping()
        {
            Mapper.Initialize(x =>
                {
                    x.AddProfile<DomainToViewModelMappingProfile>();
                    x.AddProfile<ViewModelToDomainMappingProfile>();
                });
        }
    }
}