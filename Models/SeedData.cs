﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVC5_mockup.Data;
using System;
using System.Linq;

namespace MVC5_mockup.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcDeviceContext(serviceProvider.GetRequiredService<DbContextOptions<MvcDeviceContext>>()))
            {
                // Look for devices
                if (context.Device.Any())
                {
                    return; //Db is properly seeded
                }

                context.Device.AddRange(
                    new Device
                    {
                        Name = "Device_01",
                        Status = true
                    },
                    new Device
                    {
                        Name = "Device_02",
                        Status = true
                    },
                    new Device
                    {
                        Name = "Device_03",
                        Status = false
                    },
                    new Device
                    {
                        Name = "Device_04",
                        Status = true
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
