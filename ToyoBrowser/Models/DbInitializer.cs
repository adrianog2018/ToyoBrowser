using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyoBrowser.Models
{
    public static class DbInitializer
    {
        public static void Initialize(ToyoContext context)
        {
            //context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            if (context.Brands.Any())
            {
                return;
            }

            var brand = new Brand
            {
                Name = "Toyota"
            };

            context.Brands.Add(brand);
            context.SaveChanges();


            var features = new List<Features>
            {
                new Features()
                {
                    Name = "Reverse Camera",
                    Description = "Reverse Camera with line guidance"
                },
                new Features()
                {
                    Name = "TSS",
                    Description = "Toyota Safety Sense"
                },

                new Features()
                {
                    Name = "Moonroof",
                    Description = "Power tilt/slide moonroof with sunshade"
                },

                new Features()
                {
                    Name = "Panoramic Moonroof",
                    Description = "Huge panoramic moonroof"
                },

                new Features()
                {
                    Name = "Entune 3.0 Audio",
                    Description = "Inmersive sound system"
                },

                new Features()
                {
                    Name = "JBL Audio",
                    Description = "High fidelity audio system"
                },

                new Features()
                {
                    Name = "BSM",
                    Description = "Blind Spot Monitor"
                },
            };

            context.Features.AddRange(features);
            context.SaveChanges();

            // motor

            var motors = new List<Motor>()
            {
                new Motor
                {
                    Identifier = "camry2.5",
                    BrandId = brand.Id,
                    Cc = 2.5f,
                    HorsePowers = 203
                },
                new Motor
                {
                    Identifier = "camry3.5",
                    BrandId = brand.Id,
                    Cc = 3.5f,
                    HorsePowers = 301
                },
                new Motor
                {
                    Identifier = "corolla1.8",
                    BrandId = brand.Id,
                    Cc = 1.8f,
                    HorsePowers = 132
                },
                new Motor
                {
                    Identifier = "prime",
                    BrandId = brand.Id,
                    Cc = 1.8f,
                    HorsePowers = 121
                },
                new Motor
                {
                    Identifier = "prius",
                    BrandId = brand.Id,
                    Cc = 1.8f,
                    HorsePowers = 121
                },
                new Motor
                {
                    Identifier = "highlanderhybrid",
                    BrandId = brand.Id,
                    Cc = 3.5f,
                    HorsePowers = 306
                },
                new Motor
                {
                    Identifier = "rav4hybrid",
                    BrandId = brand.Id,
                    Cc = 2.5f,
                    HorsePowers = 194
                },
                new Motor
                {
                    Identifier = "avalonhybrid",
                    BrandId = brand.Id,
                    Cc = 2.5f,
                    HorsePowers = 176
                },
                new Motor
                {
                    Identifier = "camryhybrid",
                    BrandId = brand.Id,
                    Cc = 2.5f,
                    HorsePowers = 176
                },
                new Motor
                {
                    Identifier = "landcruiser",
                    BrandId = brand.Id,
                    Cc = 5.7f,
                    HorsePowers = 381
                },
                new Motor
                {
                    Identifier = "sequoia",
                    BrandId = brand.Id,
                    Cc = 5.7f,
                    HorsePowers = 381
                },
                new Motor
                {
                    Identifier = "4runner",
                    BrandId = brand.Id,
                    Cc = 4.0f,
                    HorsePowers = 270
                },
                new Motor
                {
                    Identifier = "priusc",
                    BrandId = brand.Id,
                    Cc = 1.5f,
                    HorsePowers = 73
                },
                new Motor
                {
                    Identifier = "highlanderl4",
                    BrandId = brand.Id,
                    Cc = 2.7f,
                    HorsePowers = 185
                },
                new Motor
                {
                    Identifier = "highlanderv6",
                    BrandId = brand.Id,
                    Cc = 3.5f,
                    HorsePowers = 295
                },
                new Motor
                {
                    Identifier = "chr",
                    BrandId = brand.Id,
                    Cc = 2.0f,
                    HorsePowers = 144
                },
                new Motor
                {
                    Identifier = "tundra4.6",
                    BrandId = brand.Id,
                    Cc = 4.6f,
                    HorsePowers = 310
                },
                new Motor
                {
                    Identifier = "tundra5.7",
                    BrandId = brand.Id,
                    Cc = 5.7f,
                    HorsePowers = 381
                },
                new Motor
                {
                    Identifier = "tacoma2.7",
                    BrandId = brand.Id,
                    Cc = 2.7f,
                    HorsePowers = 159
                },
                new Motor
                {
                    Identifier = "tacoma3.5",
                    BrandId = brand.Id,
                    Cc = 3.5f,
                    HorsePowers = 278
                },
                new Motor
                {
                    Identifier = "avalon",
                    BrandId = brand.Id,
                    Cc = 3.5f,
                    HorsePowers = 301
                },
                new Motor
                {
                    Identifier = "yaris",
                    BrandId = brand.Id,
                    Cc = 1.5f,
                    HorsePowers = 106
                },
                new Motor
                {
                    Identifier = "corollahatchback",
                    BrandId = brand.Id,
                    Cc = 2.0f,
                    HorsePowers = 168
                },
                new Motor
                {
                    Identifier = "sienna",
                    BrandId = brand.Id,
                    Cc = 3.5f,
                    HorsePowers = 296
                },
                new Motor
                {
                    Identifier = "86",
                    BrandId = brand.Id,
                    Cc = 2.0f,
                    HorsePowers = 205
                },
                new Motor
                {
                    Identifier = "rav4",
                    BrandId = brand.Id,
                    Cc = 2.5f,
                    HorsePowers = 203
                },
                new Motor
                {
                    Identifier = "mirai",
                    BrandId = brand.Id,
                    Cc = 0.0f,
                    HorsePowers = 151
                },

            };

            context.Motors.AddRange(motors);
            context.SaveChanges();

            //---- MODEL

            var models = new List<Model>()
            {
                new Model
                {
                    Name = "Camry",

                },
                new Model
                {
                    Name = "Corolla",

                },
                new Model
                {
                    Name = "86",

                },
                new Model
                {
                    Name = "Sienna",

                },
                new Model
                {
                    Name = "Corolla Hatchback",

                },
                new Model
                {
                    Name = "Yaris",

                },
                new Model
                {
                    Name = "Avalon",

                },
                new Model
                {
                    Name = "Tacoma",

                },
                new Model
                {
                    Name = "Tundra",

                },
                new Model
                {
                    Name = "C-HR",

                },
                new Model
                {
                    Name = "RAV4",

                },
                new Model
                {
                    Name = "Highlander",
                },
                new Model
                {
                    Name = "4Runner",
                },
                new Model
                {
                    Name = "Sequoia",
                },
                new Model
                {
                    Name = "Land Cruiser",
                },
                new Model
                {
                    Name = "Camry Hybrid",
                },
                new Model
                {
                    Name = "Avalon Hybrid",
                },
                new Model
                {
                    Name = "RAV4 Hybrid",
                },
                new Model
                {
                    Name = "Highlander Hybrid",
                },
                new Model
                {
                    Name = "Prius",
                },
                new Model
                {
                    Name = "Prius Prime",
                },
                new Model
                {
                    Name = "Prius C",
                },
                new Model
                {
                    Name = "Mirai",
                },
            };




            context.Models.AddRange(models);
            context.SaveChanges();

            // ---trim level

            var trimLevels = new List<TrimsLevel>()
            {
                // --- Camry
                
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/camry/camry_l-side.png",
                    ModelNumber = "2514",
                    Description = "L 2.5-L 4-Cylinder 8-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "camry2.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Camry").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/camry/camry_le-side.png",
                    ModelNumber = "2532",
                    Description = "LE 2.5-L 4-Cylinder 8-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "camry2.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Camry").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/camry/camry_xle-side.png",
                    ModelNumber = "2540",
                    Description = "XLE 2.5-L 4-Cylinder 8-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "camry2.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Camry").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/camry/camry_se-side.png",
                    ModelNumber = "2546",
                    Description = "SE 2.5-L 4-Cylinder 8-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "camry2.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Camry").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/camry/camry_xse-side.png",
                    ModelNumber = "2548",
                    Description = "XSE 2.5-L 4-Cylinder 8-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "camry2.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Camry").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/camry/camry_xle_v6-side.png",
                    ModelNumber = "2554",
                    Description = "XLEv6 3.5-L V6 8-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "camry3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Camry").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/camry/camry_xse_v6-side.png",
                    ModelNumber = "2550",
                    Description = "XSEv6 3.5-L V6 8-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "camry3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Camry").Id
                },
                
                // --- Camry Hybrid

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/camry/camry_hybrid_le-side.png",
                    ModelNumber = "2559",
                    Description = "Hybrid LE 2.5-L 4-Cylinder ECVT Hybrid",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "camryhybrid").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Camry Hybrid").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/camry/camry_hybrid_se-side.png",
                    ModelNumber = "2560",
                    Description = "Hybrid SE 2.5-L 4-Cylinder ECVT Hybrid",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "camryhybrid").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Camry Hybrid").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/camry/camry_hybrid_xle-side.png",
                    ModelNumber = "2561",
                    Description = "Hybrid XLE 2.5-L 4-Cylinder ECVT Hybrid",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "camryhybrid").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Camry Hybrid").Id
                },

                // --- Corolla
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2020/corolla/l-side.png",
                    ModelNumber = "1832",
                    Description = "L 1.8L 4-Cylinder (CVT)",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "corolla1.8").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Corolla").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2020/corolla/le-side.png",
                    ModelNumber = "1852",
                    Description = "LE 1.8L 4-Cylinder (CVT)",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "corolla1.8").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Corolla").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2020/corolla/xle-side.png",
                    ModelNumber = "1856",
                    Description = "XLE 1.8L 4-Cylinder (CVT)",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "corolla1.8").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Corolla").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2020/corolla/se-side.png",
                    ModelNumber = "1864",
                    Description = "SE 1.8L 4-Cylinder (CVT)",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "corolla1.8").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Corolla").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2020/corolla/xse-side.png",
                    ModelNumber = "1866",
                    Description = "XSE 1.8L 4-Cylinder (CVT)",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "corolla1.8").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Corolla").Id
                },
                
                // --- yaris
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/yaris/l-side.png",
                    ModelNumber = "6267",
                    Description = "L 1.5L 4-Cylinder 6-Speed Manual",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "yaris").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Yaris").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/yaris/l-side.png",
                    ModelNumber = "6266",
                    Description = "L 1.5L 4-Cylinder 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "yaris").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Yaris").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/yaris/le-side.png",
                    ModelNumber = "6263",
                    Description = "LE 1.5L 4-Cylinder 6-Speed Manual",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "yaris").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Yaris").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/yaris/le-side.png",
                    ModelNumber = "6262",
                    Description = "LE 1.5L 4-Cylinder 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "yaris").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Yaris").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/yaris/xle-side.png",
                    ModelNumber = "6268",
                    Description = "XLE 1.5L 4-Cylinder 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "yaris").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Yaris").Id
                },
                
                // --- 86

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/86-side.png",
                    ModelNumber = "6253",
                    Description = "86 2.0L 4-Cylinder 6-Speed Manual",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "86").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "86").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/86-side.png",
                    ModelNumber = "6252",
                    Description = "86 2.0L 4-Cylinder 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "86").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "86").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/86/86gt-side.png",
                    ModelNumber = "6255",
                    Description = "GT 2.0L 4-Cylinder 6-Speed Manual",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "86").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "86").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/86/86gt-side.png",
                    ModelNumber = "6254",
                    Description = "GT 2.0L 4-Cylinder 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "86").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "86").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/86/86trd-side.png",
                    ModelNumber = "6251",
                    Description = "TRD Special Edition 2.0L 4-Cylinder 6-Speed Manual",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "86").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "86").Id
                },
                // --- Avalon
                
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/avalon/xle-side.png",
                    ModelNumber = "3544",
                    Description = "XLE 3.5-Liter V6 8-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "avalon").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Avalon").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/avalon/xse-side.png",
                    ModelNumber = "3547",
                    Description = "XSE 3.5-Liter V6 8-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "avalon").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Avalon").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/avalon/limited-side.png",
                    ModelNumber = "3554",
                    Description = "Limited 3.5-Liter V6 8-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "avalon").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Avalon").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/avalon/touring-side.png",
                    ModelNumber = "3548",
                    Description = "Touring 3.5-Liter V6 8-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "avalon").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Avalon").Id
                },

                // --- Avalon Hybrid

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/avalonhybrid/hybrid-xle-side.png",
                    ModelNumber = "3504",
                    Description = "Hybrid XLE 2.5-Liter 4-Cylinder ECVT Hybrid",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "avalonhybrid").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Avalon Hybrid").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/avalonhybrid/hybrid-xse-side.png",
                    ModelNumber = "3507",
                    Description = "Hybrid XSE 2.5-Liter 4-Cylinder ECVT Hybrid",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "avalonhybrid").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Avalon Hybrid").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/avalonhybrid/hybrid-limited-side.png",
                    ModelNumber = "3514",
                    Description = "Hybrid Limited 2.5-Liter 4-Cylinder ECVT Hybrid",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "avalonhybrid").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Avalon Hybrid").Id
                },

                // --- corolla hatchback

                 new TrimsLevel
                 {
                     TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/corollahatchback/se-side.png",
                    ModelNumber = "6273",
                    Description = "SE L4 2.0L (6MT)",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "corollahatchback").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Corolla Hatchback").Id
                 },

                 new TrimsLevel
                 {
                     TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/corollahatchback/se-side.png",
                    ModelNumber = "6272",
                    Description = "SE L4 2.0L (CVT)",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "corollahatchback").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Corolla Hatchback").Id
                 },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/corollahatchback/xse-side.png",
                    ModelNumber = "6275",
                    Description = "XSE L4 2.0L (6MT)",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "corollahatchback").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Corolla Hatchback").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/corollahatchback/xse-side.png",
                    ModelNumber = "6274",
                    Description = "XSE L4 2.0L (CVT)",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "corollahatchback").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Corolla Hatchback").Id
                },

                // --- Prius

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/prius/l-eco-side.png",
                    ModelNumber = "1221",
                    Description = "L Eco 1.8L 4-Cyl. Hybrid",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "prius").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Prius").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/prius/le-side.png",
                    ModelNumber = "1223",
                    Description = "LE 1.8L 4-Cyl. Hybrid",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "prius").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Prius").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/prius/xle-side.png",
                    ModelNumber = "1225",
                    Description = "XLE 1.8L 4-Cyl. Hybrid",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "prius").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Prius").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/prius/limited-side.png",
                    ModelNumber = "1227",
                    Description = "Limited 1.8L 4-Cyl. Hybrid",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "prius").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Prius").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/prius/le-side.png",
                    ModelNumber = "1263",
                    Description = "LE AWD-e 1.8L 4-Cyl. Hybrid",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "prius").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Prius").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/prius/xle-side.png",
                    ModelNumber = "1265",
                    Description = "XLE AWD-e 1.8L 4-Cyl. Hybrid",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "prius").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Prius").Id
                },

                // --- Prius C

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/priusc/prius_c_l-side.png",
                    ModelNumber = "1201",
                    Description = "L 1.5L 4-Cyl. ECVT Hybrid",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "priusc").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Prius C").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/priusc/prius_c_le-side.png",
                    ModelNumber = "1205",
                    Description = "LE 1.5L 4-Cyl. ECVT Hybrid",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "priusc").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Prius C").Id
                },

                // --- Prius Prime

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/priusprime/plus-side.png",
                    ModelNumber = "1235",
                    Description = "Plus",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "prime").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Prius Prime").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/priusprime/premium-side.png",
                    ModelNumber = "1237",
                    Description = "Premium",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "prime").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Prius Prime").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/priusprime/advanced-side.png",
                    ModelNumber = "1239",
                    Description = "Advanced",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "prime").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Prius Prime").Id
                },
                // --- Mirai
                
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/mirai-side.png",
                    ModelNumber = "3000",
                    Description = "Fuelcell",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "mirai").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Mirai").Id
                },
                // --- Sienna

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sienna/l-side.png",
                    ModelNumber = "5328",
                    Description = "L FWD 7-Passenger 3.5L V6 Direct Shift-8AT Auto",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sienna").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sienna").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sienna/le-side.png",
                    ModelNumber = "5338",
                    Description = "LE FWD 8-Passenger 3.5L V6 Direct Shift-8AT Auto",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sienna").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sienna").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sienna/le-side.png",
                    ModelNumber = "5366",
                    Description = "LE AWD 7-Passenger 3.5L V6 Direct Shift-8AT Auto",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sienna").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sienna").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sienna/le-side.png",
                    ModelNumber = "5335",
                    Description = "LE FWD with Auto Access Seat 7-Passenger 3.5L V6 Direct Shift-8AT Auto",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sienna").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sienna").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sienna/se-side.png",
                    ModelNumber = "5342",
                    Description = "SE FWD 8-Passenger 3.5L V6 Direct Shift-8AT Auto",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sienna").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sienna").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sienna/se-side.png",
                    ModelNumber = "5352",
                    Description = "SE AWD 7-Passenger 3.5L V6 Direct Shift-8AT Auto",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sienna").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sienna").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sienna/se-side.png",
                    ModelNumber = "5343",
                    Description = "SE Premium FWD 8-Passenger 3.5L V6",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sienna").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sienna").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sienna/se-side.png",
                    ModelNumber = "5353",
                    Description = "SE Premium AWD 7-Passenger 3.5L V6",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sienna").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sienna").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sienna/xle-side.png",
                    ModelNumber = "5348",
                    Description = "XLE FWD 8-Passenger 3.5L V6 Direct Shift-8AT Auto",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sienna").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sienna").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sienna/xle-side.png",
                    ModelNumber = "5376",
                    Description = "XLE AWD 7-Passenger 3.5L V6 Direct Shift-8AT Auto",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sienna").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sienna").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sienna/xle-side.png",
                    ModelNumber = "5349",
                    Description = "XLE Premium FWD 8-Passenger 3.5L V6",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sienna").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sienna").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sienna/xle-side.png",
                    ModelNumber = "5377",
                    Description = "XLE Premium AWD 7-Passenger 3.5L V6",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sienna").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sienna").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sienna/xle-side.png",
                    ModelNumber = "5345",
                    Description = "XLE FWD with Auto Access Seat 7-Passenger 3.5L V6 Direct Shift-8AT Auto",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sienna").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sienna").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sienna/limited-side.png",
                    ModelNumber = "5356",
                    Description = "Limited FWD 7-Passenger 3.5L V6 Direct Shift-8AT Auto",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sienna").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sienna").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sienna/limited-side.png",
                    ModelNumber = "5386",
                    Description = "Limited AWD 7-Passenger 3.5L V6 Direct Shift-8AT Auto",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sienna").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sienna").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sienna/limited-side.png",
                    ModelNumber = "5357",
                    Description = "Limited Premium FWD 7-Passenger 3.5L V6",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sienna").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sienna").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sienna/limited-side.png",
                    ModelNumber = "5387",
                    Description = "Limited Premium AWD 7-Passenger 3.5L V6",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sienna").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sienna").Id
                },

                // --- C-HR

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/c-hr/le-side.png",
                    ModelNumber = "2402",
                    Description = "LE 2.0-Liter 4-Cylinder (CVTi-S)",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "chr").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "C-HR").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/c-hr/xle-side.png",
                    ModelNumber = "2404",
                    Description = "XLE 2.0-Liter 4-Cylinder (CVTi-S)",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "chr").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "C-HR").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/c-hr/limited-side.png",
                    ModelNumber = "2408",
                    Description = "Limited 2.0-Liter 4-Cylinder (CVTi-S)",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "chr").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "C-HR").Id
                },
                
                // --- RAV4
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/rav4/le-side.png",
                    ModelNumber = "4430",
                    Description = "LE FWD 2.5L 4-Cyl.",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "rav4").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "RAV4").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/rav4/le-side.png",
                    ModelNumber = "4432",
                    Description = "LE AWD 2.5L 4-Cyl.",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "rav4").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "RAV4").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/rav4/xle-side.png",
                    ModelNumber = "4440",
                    Description = "XLE FWD 2.5L 4-Cyl.",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "rav4").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "RAV4").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/rav4/xle-side.png",
                    ModelNumber = "4442",
                    Description = "XLE AWD 2.5L 4-Cyl.",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "rav4").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "RAV4").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/rav4/xle_premium-side.png",
                    ModelNumber = "4477",
                    Description = "XLE Premium FWD 2.5L 4-Cyl.",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "rav4").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "RAV4").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/rav4/xle_premium-side.png",
                    ModelNumber = "4478",
                    Description = "XLE Premium AWD 2.5L 4-Cyl.",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "rav4").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "RAV4").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/rav4/adventure-side.png",
                    ModelNumber = "4446",
                    Description = "Adventure AWD 2.5L 4-Cyl.",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "rav4").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "RAV4").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/rav4/limited-side.png",
                    ModelNumber = "4450",
                    Description = "Limited FWD 2.5L 4-Cyl.",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "rav4").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "RAV4").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/rav4/limited-side.png",
                    ModelNumber = "4452",
                    Description = "Limited AWD 2.5L 4-Cyl.",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "rav4").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "RAV4").Id
                },

                // --- RAV4 Hybrid
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2018/rav4hybrid/le-hybrid-side.png",
                    ModelNumber = "4435",
                    Description = "LE Hybrid 2.5L 4-Cyl. ECVT Hybrid",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "rav4hybrid").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "RAV4 Hybrid").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2018/rav4hybrid/xle-hybrid-side.png",
                    ModelNumber = "4444",
                    Description = "XLE Hybrid 2.5L 4-Cyl. ECVT Hybrid",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "rav4hybrid").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "RAV4 Hybrid").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2018/rav4hybrid/xle-hybrid-side.png",
                    ModelNumber = "4456",
                    Description = "XSE Hybrid 2.5L 4-Cyl. ECVT Hybrid",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "rav4hybrid").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "RAV4 Hybrid").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2018/rav4hybrid/limited-hybrid-side.png",
                    ModelNumber = "4454",
                    Description = "Limited Hybrid 2.5L 4-Cyl. ECVT Hybrid",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "rav4hybrid").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "RAV4 Hybrid").Id
                },

                // --- Highlander
                
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/highlander/le-side.png",
                    ModelNumber = "6942",
                    Description = "LE FWD 2.7L 4-Cyl. 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "highlanderl4").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Highlander").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/highlander/le-side.png",
                    ModelNumber = "6946",
                    Description = "LE FWD 3.5L V6. 8-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "highlanderv6").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Highlander").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/highlander/le-side.png",
                    ModelNumber = "6948",
                    Description = "LE AWD 3.5L V6. 8-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "highlanderv6").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Highlander").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/highlander/plus-side.png",
                    ModelNumber = "6947",
                    Description = "LE Plus FWD 3.5L V6 Direct Shift 8-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "highlanderv6").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Highlander").Id
                },
                //--
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/highlander/plus-side.png",
                    ModelNumber = "6949",
                    Description = "LE Plus AWD 3.5L V6 Direct Shift 8-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "highlanderv6").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Highlander").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/highlander/xle-side.png",
                    ModelNumber = "6951",
                    Description = "XLE FWD 3.5L V6 Direct Shift 8-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "highlanderv6").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Highlander").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/highlander/xle-side.png",
                    ModelNumber = "6953",
                    Description = "XLE AWD 3.5L V6 Direct Shift 8-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "highlanderv6").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Highlander").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/highlander/se-side.png",
                    ModelNumber = "6950",
                    Description = "SE FWD 3.5L V6 Direct Shift 8-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "highlanderv6").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Highlander").Id
                },
                //--
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/highlander/se-side.png",
                    ModelNumber = "6952",
                    Description = "SE AWD 3.5L V6 Direct Shift 8-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "highlanderv6").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Highlander").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/highlander/limited-side.png",
                    ModelNumber = "6954",
                    Description = "Limited FWD 3.5L V6 Direct Shift 8-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "highlanderv6").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Highlander").Id
                },
                //----
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/highlander/limited-side.png",
                    ModelNumber = "6956",
                    Description = "Limited AWD 3.5L V6 Direct Shift 8-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "highlanderv6").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Highlander").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/highlander/limited-side.png",
                    ModelNumber = "6955",
                    Description = "Limited FWD 3.5L V6 Direct Shift 8-Speed Automatic with Platinum Package",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "highlanderv6").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Highlander").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/highlander/limited-side.png",
                    ModelNumber = "6957",
                    Description = "Limited AWD 3.5L V6 Direct Shift 8-Speed Automatic with Platinum Package",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "highlanderv6").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Highlander").Id
                },
                
                // --- Highlander Hybrid

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/highlanderhybrid/hybrid-le-side.png",
                    ModelNumber = "6964",
                    Description = "Hybrid LE AWD-i 3.5L V6 ECVT Hybrid",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "highlanderhybrid").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Highlander Hybrid").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/highlanderhybrid/hybrid-xle-side.png",
                    ModelNumber = "6965",
                    Description = "Hybrid XLE AWD-i 3.5L V6 ECVT Hybrid",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "highlanderhybrid").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Highlander Hybrid").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/highlanderhybrid/hybrid-limited-side.png",
                    ModelNumber = "6966",
                    Description = "Hybrid Limited AWD-i 3.5L V6 ECVT Hybrid",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "highlanderhybrid").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Highlander Hybrid").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/highlanderhybrid/hybrid-limited-side.png",
                    ModelNumber = "6967",
                    Description = "Hybrid Limited AWD-i 3.5L V6 ECVT Hybrid with Platinum Package",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "highlanderhybrid").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Highlander Hybrid").Id
                },

                // --- 4Runner
                
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/4runner/sr5-side.png",
                    ModelNumber = "8642",
                    Description = "SR5 4x2 4.0L V6 5-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "4runner").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "4Runner").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/4runner/sr5-side.png",
                    ModelNumber = "8664",
                    Description = "SR5 4x4 4.0L V6 5-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "4runner").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "4Runner").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/4runner/sr5_premium-side.png",
                    ModelNumber = "8646",
                    Description = "SR5 4x2 Premium 4.0L V6 5-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "4runner").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "4Runner").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/4runner/sr5_premium-side.png",
                    ModelNumber = "8666",
                    Description = "SR5 4x4 Premium 4.0L V6 5-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "4runner").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "4Runner").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/4runner/trd-side.png",
                    ModelNumber = "8670",
                    Description = "TRD Off-Road 4x4 4.0L V6 5-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "4runner").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "4Runner").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/4runner/trd_off_road_premium-side.png",
                    ModelNumber = "8672",
                    Description = "TRD Off-Road 4x4 Premium 4.0L V6 5-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "4runner").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "4Runner").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/4runner/limited-side.png",
                    ModelNumber = "8648",
                    Description = "Limited 4x2 4.0L V6 5-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "4runner").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "4Runner").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/4runner/limited-side.png",
                    ModelNumber = "8668",
                    Description = "Limited 4x4 4.0L V6 5-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "4runner").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "4Runner").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/4runner/limited_nightshade_edition-side.png",
                    ModelNumber = "8649",
                    Description = "Limited Nightshade Edition 4x2 4.0L V6 5-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "4runner").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "4Runner").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/4runner/limited_nightshade_edition-side.png",
                    ModelNumber = "8669",
                    Description = "Limited Nightshade Edition 4x4 4.0L V6 5-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "4runner").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "4Runner").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/4runner/trd-side.png",
                    ModelNumber = "8674",
                    Description = "TRD Pro 4x4 4.0L V6 5-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "4runner").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "4Runner").Id
                },

                // --- Sequoia
                
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sequoia/sr5-side.png",
                    ModelNumber = "7917",
                    Description = "SR5 2WD 5.7L V8 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sequoia").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sequoia").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sequoia/sr5-side.png",
                    ModelNumber = "7919",
                    Description = "SR5 4WD 5.7L V8 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sequoia").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sequoia").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sequoia/trd_sport-side.png",
                    ModelNumber = "7921",
                    Description = "TRD Sport 2WD 5.7L V8 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sequoia").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sequoia").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sequoia/trd_sport-side.png",
                    ModelNumber = "7922",
                    Description = "TRD Sport 4WD 5.7L V8 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sequoia").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sequoia").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sequoia/limited-side.png",
                    ModelNumber = "7927",
                    Description = "Limited 2WD 5.7L V8 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sequoia").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sequoia").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sequoia/limited-side.png",
                    ModelNumber = "7929",
                    Description = "Limited 4WD 5.7L V8 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sequoia").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sequoia").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sequoia/platinum-side.png",
                    ModelNumber = "7931",
                    Description = "Platinum 2WD 5.7L V8 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sequoia").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sequoia").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/sequoia/platinum-side.png",
                    ModelNumber = "7933",
                    Description = "Platinum 4WD 5.7L V8 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "sequoia").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Sequoia").Id
                },

                // --- Land Cruiser

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/landcruiser/landcruiser-side.png",
                    ModelNumber = "6156",
                    Description = "Land Cruiser 4WD 5.7L V8 8-Speed Automatic Transmission",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "landcruiser").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Land Cruiser").Id
                },

                // --- TACOMA 
                // --- TACOMA SR
                 
                                
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/sr-side.png",
                    ModelNumber = "7162",
                    Description = "SR 4x2 Access Cab 4-Cyl. 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma2.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/sr-side.png",
                    ModelNumber = "7186",
                    Description = "SR 4x2 Double Cab 4-Cyl. 6-Speed Automatic Short Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma2.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/sr-side.png",
                    ModelNumber = "7514",
                    Description = "SR 4x4 Access Cab 4-Cyl. 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma2.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/sr-side.png",
                    ModelNumber = "7164",
                    Description = "SR 4x2 Access Cab V6. 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/sr-side.png",
                    ModelNumber = "7594",
                    Description = "SR 4x4 Double Cab V6. 6-Speed Automatic Short Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/sr-side.png",
                    ModelNumber = "7552",
                    Description = "SR 4x4 Access Cab V6. 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                // TACOMA SR5
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/sr5-side.png",
                    ModelNumber = "7122",
                    Description = "SR5 4x2 Access Cab 4-Cyl. 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma2.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/sr5-side.png",
                    ModelNumber = "7126",
                    Description = "SR5 4x2 Access Cab V6. 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/sr5-side.png",
                    ModelNumber = "7185",
                    Description = "SR5 4x2 Double Cab 4-Cyl. 6-Speed Automatic Short Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma2.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/sr5-side.png",
                    ModelNumber = "7146",
                    Description = "SR5 4x2 Double Cab V6. 6-Speed Automatic Short Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/sr5-side.png",
                    ModelNumber = "7170",
                    Description = "SR5 4x2 Double Cab V6 6-Speed Automatic Long Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/sr5-side.png",
                    ModelNumber = "7516",
                    Description = "SR5 4x4 Access Cab 4-Cyl. 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma2.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/sr5-side.png",
                    ModelNumber = "7558",
                    Description = "SR5 4x4 Access Cab V6. 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/sr5-side.png",
                    ModelNumber = "7540",
                    Description = "SR5 4x4 Double Cab V6. 6-Speed Automatic Short Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/sr5-side.png",
                    ModelNumber = "7570",
                    Description = "SR5 4x4 Double Cab V6. 6-Speed Automatic Long Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                // TACOMA TRD Sport
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/trd_sport-side.png",
                    ModelNumber = "7128",
                    Description = "TRD Sport 4x2 Access Cab V6. 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/trd_sport-side.png",
                    ModelNumber = "7148",
                    Description = "TRD Sport 4x2 Double Cab V6. 6-Speed Automatic Short Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/trd_sport-side.png",
                    ModelNumber = "7172",
                    Description = "TRD Sport 4x2 Double Cab V6. 6-Speed Automatic Long Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/trd_sport-side.png",
                    ModelNumber = "7560",
                    Description = "TRD Sport 4x4 Access Cab V6. 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/trd_sport-side.png",
                    ModelNumber = "7559",
                    Description = "TRD Sport 4x4 Access Cab V6. 6-Speed Manual",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/trd_sport-side.png",
                    ModelNumber = "7542",
                    Description = "TRD Sport 4x4 Double Cab V6. 6-Speed Automatic Short Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/trd_sport-side.png",
                    ModelNumber = "7566",
                    Description = "TRD Sport 4x4 Double Cab V6. 6-Speed Automatic Long Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/trd_sport-side.png",
                    ModelNumber = "7543",
                    Description = "TRD Sport 4x4 Double Cab V6. 6-Speed Manual Short Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                // Tacoma TRD Off-Road

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/trd_off_road-side.png",
                    ModelNumber = "7150",
                    Description = "TRD Off-Road 4x2 Double Cab V6. 6-Speed Automatic Short Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/trd_off_road-side.png",
                    ModelNumber = "7562",
                    Description = "TRD Off-Road 4x4 Access Cab V6. 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/trd_off_road-side.png",
                    ModelNumber = "7544",
                    Description = "TRD Off-Road 4x4 Double Cab V6. 6-Speed Automatic Short Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/trd_off_road-side.png",
                    ModelNumber = "7568",
                    Description = "TRD Off-Road 4x4 Double Cab V6. 6-Speed Automatic Long Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/trd_off_road-side.png",
                    ModelNumber = "7545",
                    Description = "TRD Off-Road 4x4 Double Cab V6. 6-Speed Manual Short Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                // --- Tacoma Limited

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/limited-side.png",
                    ModelNumber = "7182",
                    Description = "Limited 4x2 Double Cab V6. 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/limited-side.png",
                    ModelNumber = "7582",
                    Description = "Limited 4x4 Double Cab V6. 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                // --- Tacoma TRD Pro

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/trd_pro-side.png",
                    ModelNumber = "7598",
                    Description = "TRD Pro 4x4 Double Cab V6. 6-Speed Automatic",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tacoma/trd_pro-side.png",
                    ModelNumber = "7597",
                    Description = "TRD Pro 4x4 Double Cab V6. 6-Speed Manual",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tacoma3.5").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tacoma").Id
                },

                // --- Tundra 
                // --- Tundra SR

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/sr-side.png",
                    ModelNumber = "8239",
                    Description = "SR 4x2 Double Cab 4.6L V8 6.5-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra4.6").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },


                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/sr-side.png",
                    ModelNumber = "8242",
                    Description = "SR 4x2 Double Cab 5.7L V8 6.5-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra5.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/sr-side.png",
                    ModelNumber = "8245",
                    Description = "SR 4x2 Double Cab 5.7L V8 8.1-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra5.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/sr-side.png",
                    ModelNumber = "8339",
                    Description = "SR 4x4 Double Cab 4.6L V8 6.5-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra4.6").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/sr-side.png",
                    ModelNumber = "8342",
                    Description = "SR 4x4 Double Cab 5.7L V8 6.5-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra5.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/sr-side.png",
                    ModelNumber = "8345",
                    Description = "SR 4x4 Double Cab 5.7L V8 8.1-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra5.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },

                // --- Tundra SR5

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/sr5-side.png",
                    ModelNumber = "8240",
                    Description = "SR5 4x2 Double Cab 4.6L V8 6.5-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra4.6").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },


                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/sr5-side.png",
                    ModelNumber = "8241",
                    Description = "SR5 4x2 Double Cab 5.7L V8 6.5-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra5.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/sr5-side.png",
                    ModelNumber = "8246",
                    Description = "SR5 4x2 Double Cab 5.7L V8 8.1-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra5.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/sr5-side.png",
                    ModelNumber = "8259",
                    Description = "SR5 4x2 CrewMax 4.6L V8 5.5-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra4.6").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },


                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/sr5-side.png",
                    ModelNumber = "8261",
                    Description = "SR5 4x2 CrewMax 5.7L V8 5.5-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra5.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/sr5-side.png",
                    ModelNumber = "8340",
                    Description = "SR5 4x4 Double Cab 4.6L V8 6.5-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra4.6").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },


                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/sr5-side.png",
                    ModelNumber = "8341",
                    Description = "SR5 4x4 Double Cab 5.7L V8 6.5-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra5.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/sr5-side.png",
                    ModelNumber = "8331",
                    Description = "SR5 4x4 Double Cab 5.7L V8 FFV 6.5-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra5.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },
                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/sr5-side.png",
                    ModelNumber = "8346",
                    Description = "SR5 4x4 Double Cab 5.7L V8 8.1-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra5.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/sr5-side.png",
                    ModelNumber = "8359",
                    Description = "SR5 4x4 CrewMax 4.6L V8 5.5-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra4.6").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },


                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/sr5-side.png",
                    ModelNumber = "8361",
                    Description = "SR5 4x4 CrewMax 5.7L V8 5.5-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra5.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/sr5-side.png",
                    ModelNumber = "8363",
                    Description = "SR5 4x4 CrewMax 5.7L V8 FFV 5.5-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra5.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },

                // -- Tundra Limited

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/limited-side.png",
                    ModelNumber = "8252",
                    Description = "Limited 4x2 Double Cab 5.7L V8 6.5-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra5.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/limited-side.png",
                    ModelNumber = "8272",
                    Description = "Limited 4x2 CrewMax 5.7L V8 5.5-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra5.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/limited-side.png",
                    ModelNumber = "8352",
                    Description = "Limited 4x4 Double Cab 5.7L V8 6.5-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra5.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/limited-side.png",
                    ModelNumber = "8372",
                    Description = "Limited 4x4 CrewMax 5.7L V8 5.5-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra5.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },

                // --- Tundra Platinum

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/platinum-side.png",
                    ModelNumber = "8275",
                    Description = "Platinum 4x2 CrewMax 5.7L V8 5.5-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra5.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/platinum-side.png",
                    ModelNumber = "8375",
                    Description = "Platinum 4x4 CrewMax 5.7L V8 5.5-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra5.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },

                // --- Tundra 1794 Edition

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/1794-side.png",
                    ModelNumber = "8276",
                    Description = "1794 Edition 4x2 CrewMax 5.7L V8 5.5-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra5.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/1794-side.png",
                    ModelNumber = "8376",
                    Description = "1794 Edition 4x4 CrewMax 5.7L V8 5.5-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra5.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },

                // --- Tundra TRD PRO

                new TrimsLevel
                {
                    TrimPicture = @"https://www.toyota.com/imgix/responsive/images/mlp/models/2019/tundra/trdpro-side.png",
                    ModelNumber = "8371",
                    Description = "4x4 CrewMax TRD Pro 5.7L V8 5.5-Ft. Bed",
                    BrandId = brand.Id,
                    MotorId = motors.FirstOrDefault(x => x.Identifier == "tundra5.7").Id,
                    Year = 2019,
                    ModelId = models.First(m => m.Name == "Tundra").Id
                },
            };

            context.TrimsLevels.AddRange(trimLevels);
            context.SaveChanges();

            //// --- trimslevel-features

            //var trimsFeatures = new List<TrimsLevel_Features>
            //{
            //    new TrimsLevel_Features
            //    {
            //        FeaturesId = features.First().Id,
            //        TrimsLevelId = trimLevels.First().Id,
            //        Standard = true,
            //    }
            //};

            //context.TrimsLevel_Features.AddRange(trimsFeatures);
            //context.SaveChanges();



            //--- Vehicle class

            var vehicleClass = new List<VehicleClass>()
            {
                new VehicleClass
                {
                    Name = "Cars and Minivan"
                },
                new VehicleClass
                {
                    Name = "Trucks"
                },
                new VehicleClass
                {
                    Name = "Crossovers & SUVs"
                },
                new VehicleClass
                {
                    Name = "Hybrids & Fuel Cell"
                },
            };

            context.VehicleClass.AddRange(vehicleClass);
            context.SaveChanges();

            //---- Vehicle
            var vehicles = new List<Vehicle>
            {
             //---cars and minivan
            new Vehicle
            {
                BrandId = brand.Id,
                ModelId = models.First(m => m.Name == "Yaris").Id,
                VehicleClassId = vehicleClass.First(vc => vc.Name == "Cars and Minivan").Id,
                ImageUrl = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/yaris-front.png"
            },
            new Vehicle
            {
                BrandId = brand.Id,
                ModelId = models.First(m => m.Name == "Corolla").Id,
                VehicleClassId = vehicleClass.First(vc => vc.Name == "Cars and Minivan").Id,
                ImageUrl = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/corolla-front.png"
            },
            new Vehicle
            {
                BrandId = brand.Id,
                ModelId = models.First(m => m.Name == "Corolla Hatchback").Id,
                VehicleClassId = vehicleClass.First(vc => vc.Name == "Cars and Minivan").Id,
                ImageUrl = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/corollahatchback-front.png"
            },

            new Vehicle
            {
                BrandId = brand.Id,
                ModelId = models.First(m => m.Name == "Camry").Id,
                VehicleClassId = vehicleClass.First(vc => vc.Name == "Cars and Minivan").Id,
                ImageUrl = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/camry-front.png"
            },

            new Vehicle
            {
                BrandId = brand.Id,
                ModelId = models.First(m => m.Name == "Avalon").Id,
                VehicleClassId = vehicleClass.First(vc => vc.Name == "Cars and Minivan").Id,
                ImageUrl = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/avalon-front.png"
            },

            new Vehicle
            {
                BrandId = brand.Id,
                ModelId = models.First(m => m.Name == "86").Id,
                VehicleClassId = vehicleClass.First(vc => vc.Name == "Cars and Minivan").Id,
                ImageUrl = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/86-front.png"
            },

            new Vehicle
            {
                BrandId = brand.Id,
                ModelId = models.First(m => m.Name == "Sienna").Id,
                VehicleClassId = vehicleClass.First(vc => vc.Name == "Cars and Minivan").Id,
                ImageUrl = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/sienna-front.png"
            },

            //--- trucks
            new Vehicle
            {
                BrandId = brand.Id,
                ModelId = models.First(m => m.Name == "Tacoma").Id,
                VehicleClassId = vehicleClass.First(vc => vc.Name == "Trucks").Id,
                ImageUrl = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/tacoma-front.png"
            },
            new Vehicle
            {
                BrandId = brand.Id,
                ModelId = models.First(m => m.Name == "Tundra").Id,
                VehicleClassId = vehicleClass.First(vc => vc.Name == "Trucks").Id,
                ImageUrl = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/tundra-front.png"
            },

            //--- Crossovers and SUVs

            new Vehicle
            {
                BrandId = brand.Id,
                ModelId = models.First(m => m.Name == "C-HR").Id,
                VehicleClassId = vehicleClass.First(vc => vc.Name == "Crossovers & SUVs").Id,
                ImageUrl = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/c-hr-front.png"
            },

            new Vehicle
            {
                BrandId = brand.Id,
                ModelId = models.First(m => m.Name == "RAV4").Id,
                VehicleClassId = vehicleClass.First(vc => vc.Name == "Crossovers & SUVs").Id,
                ImageUrl = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/rav4-front.png"
            },

            new Vehicle
            {
                BrandId = brand.Id,
                ModelId = models.First(m => m.Name == "Highlander").Id,
                VehicleClassId = vehicleClass.First(vc => vc.Name == "Crossovers & SUVs").Id,
                ImageUrl = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/highlander-front.png"
            },

            new Vehicle
            {
                BrandId = brand.Id,
                ModelId = models.First(m => m.Name == "4Runner").Id,
                VehicleClassId = vehicleClass.First(vc => vc.Name == "Crossovers & SUVs").Id,
                ImageUrl = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/4runner-front.png"
            },

            new Vehicle
            {
                BrandId = brand.Id,
                ModelId = models.First(m => m.Name == "Sequoia").Id,
                VehicleClassId = vehicleClass.First(vc => vc.Name == "Crossovers & SUVs").Id,
                ImageUrl = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/sequoia-front.png"
            },

            new Vehicle
            {
                BrandId = brand.Id,
                ModelId = models.First(m => m.Name == "Land Cruiser").Id,
                VehicleClassId = vehicleClass.First(vc => vc.Name == "Crossovers & SUVs").Id,
                ImageUrl = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/landcruiser-front.png"
            },

            //--- Hybrids & Fuel Cell

            new Vehicle
            {
                BrandId = brand.Id,
                ModelId = models.First(m => m.Name == "Camry Hybrid").Id,
                VehicleClassId = vehicleClass.First(vc => vc.Name == "Hybrids & Fuel Cell").Id,
                ImageUrl = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/camryhybrid-front.png"
            },

            new Vehicle
            {
                BrandId = brand.Id,
                ModelId = models.First(m => m.Name == "Avalon Hybrid").Id,
                VehicleClassId = vehicleClass.First(vc => vc.Name == "Hybrids & Fuel Cell").Id,
                ImageUrl = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/avalonhybrid-front.png"
            },

            new Vehicle
            {
                BrandId = brand.Id,
                ModelId = models.First(m => m.Name == "RAV4 Hybrid").Id,
                VehicleClassId = vehicleClass.First(vc => vc.Name == "Hybrids & Fuel Cell").Id,
                ImageUrl = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2018/rav4hybrid-front.png"
            },

            new Vehicle
            {
                BrandId = brand.Id,
                ModelId = models.First(m => m.Name == "Highlander Hybrid").Id,
                VehicleClassId = vehicleClass.First(vc => vc.Name == "Hybrids & Fuel Cell").Id,
                ImageUrl = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/highlanderhybrid-front.png"
            },

            new Vehicle
            {
                BrandId = brand.Id,
                ModelId = models.First(m => m.Name == "Prius Prime").Id,
                VehicleClassId = vehicleClass.First(vc => vc.Name == "Hybrids & Fuel Cell").Id,
                ImageUrl = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/priusprime-front.png"
            },

            new Vehicle
            {
                BrandId = brand.Id,
                ModelId = models.First(m => m.Name == "Prius").Id,
                VehicleClassId = vehicleClass.First(vc => vc.Name == "Hybrids & Fuel Cell").Id,
                ImageUrl = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/prius-front.png"
            },

            new Vehicle
            {
                BrandId = brand.Id,
                ModelId = models.First(m => m.Name == "Prius C").Id,
                VehicleClassId = vehicleClass.First(vc => vc.Name == "Hybrids & Fuel Cell").Id,
                ImageUrl = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/priusc-front.png"
            },

            new Vehicle
            {
                BrandId = brand.Id,
                ModelId = models.First(m => m.Name == "Mirai").Id,
                VehicleClassId = vehicleClass.First(vc => vc.Name == "Hybrids & Fuel Cell").Id,
                ImageUrl = @"https://www.toyota.com/imgix/content/common/img/jellies/homepage/2019/mirai-front.png"
            }
        };
            
            context.Vehicles.AddRange(vehicles);

            context.SaveChanges();

            //trims level features

            var reverseCamera = features.FirstOrDefault(f => f.Name == "Reverse Camera").Id;
            var moonRoof = features.FirstOrDefault(f => f.Name == "Moonroof").Id;

            var trimsLevel4440 = context.TrimsLevels.FirstOrDefault(tl => tl.ModelNumber == "4440").Id;

            var tlf = context.TrimsLevels.ToList().Select(t =>
            new TrimsLevel_Features
            {
                TrimsLevelId = t.Id,
                FeaturesId = reverseCamera,
                Standard = true
            }
            ).ToList();

            var featureToAdd = new TrimsLevel_Features
            {
                TrimsLevelId = trimsLevel4440,
                FeaturesId = moonRoof,
                Standard = false
            };
                                   

            tlf.Add(featureToAdd);

            context.TrimsLevel_Features.AddRange(tlf);
            context.SaveChanges();



        }
    }
}
