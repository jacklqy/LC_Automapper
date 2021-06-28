
using AutoMapper;
using AutoMapper.Configuration;
using AutoMapper.QueryableExtensions;
using AutoMapperProject.MapperExpression;
using SourceType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetType;
using System.Reflection;

namespace AutoMapperProject
{
    class Program
    {
        //AutoMapper 是第三方的包
        static void Main(string[] args)
        {
            try
            {
                {
                    //硬编码
                    var source = new Source()
                    {
                        Id = 1234,
                        Name = "Richard老师",
                        //Age = 33
                    };
                    //var dest = new Dest()
                    //{
                    //    Id = source.Id,
                    //    Name = source.Name,
                    //    Age = source.Age
                    //};
                }

                #region AutoMapper初步使用
                {
                    {
                        //var config = new MapperConfiguration(cfg =>
                        //{
                        //    cfg.CreateMap<Source, Dest>(); 
                        //});
                        ////IMapper mapper=  config.CreateMapper();
                        //IMapper mapper = new Mapper(config); 
                        //Dest dest = mapper.Map<Source, Dest>(source);
                    }
                    {
                        //var cfg = new MapperConfigurationExpression();
                        ////cfg.CreateMap<Source, Dest>();
                        //cfg.AddProfile(new OrderProfile());
                        //var config = new MapperConfiguration(cfg);
                        //IMapper mapper = new Mapper(config);
                        //Dest dest = mapper.Map<Source, Dest>(source);
                    }
                }
                #endregion

                #region AutoMapper投影
                {
                    //var query = new List<Source>()
                    //{
                    //    new Source()
                    //    {
                    //        Id=123,
                    //        Name="Eleven",
                    //        Age=35
                    //    },
                    //    new Source(){
                    //        Id=234,
                    //        Name="Richard",
                    //        Age=33
                    //    },
                    //    new Source(){
                    //        Id=345,
                    //        Name="Cole",
                    //        Age=25
                    //    }
                    //}.AsQueryable();
                    ////Linq:
                    ////query.Select(item=>new Dest() {  
                    ////}) 
                    //var cfg = new MapperConfigurationExpression();
                    //cfg.CreateMap<Source, Dest>();
                    //var config = new MapperConfiguration(cfg);
                    //IMapper mapper = new Mapper(config); 
                    //var destlist= mapper.ProjectTo<Dest>(query); 
                }
                #endregion

                #region 展平
                {
                    //Order order = new Order()
                    //{
                    //    Customer = new Customer()
                    //    {
                    //        Name = "Ricahrd"
                    //    }
                    //};
                    //var product = new Product()
                    //{
                    //    Price = 5000,
                    //    Name = "笔记本"
                    //};
                    //order.AddOrderLineItem(product, 10);

                    //var config = new MapperConfiguration(cfg =>
                    //{
                    //    cfg.CreateMap<Order, OrderDto>();
                    //});
                    //IMapper mapper = config.CreateMapper();
                    //OrderDto orderDto = mapper.Map<Order, OrderDto>(order);
                }
                #endregion

                #region IncludeMembers

                //IncludeSource includeSource = new IncludeSource()
                //{
                //    Name = "Richard",
                //    InnerSource = new InnerSource()
                //    {
                //        Name = "InnerSource-Name",
                //        Description = "InnerSource-Description"
                //    },
                //    OtherInnerSource = new OtherInnerSource()
                //    {
                //        Description = "OtherInnerSource-Description",
                //        Name = "OtherInnerSource-Name",
                //        Title = "OtherInnerSource-Title"
                //    }
                //}; 
                //var cfg = new MapperConfigurationExpression();
                //cfg.CreateMap<IncludeSource, IncludeDestination>().IncludeMembers(s=>s.InnerSource,y=>y.OtherInnerSource);
                //cfg.CreateMap<InnerSource, IncludeDestination>(MemberList.None);
                //cfg.CreateMap<OtherInnerSource, IncludeDestination>(MemberList.None); 
                //var config = new MapperConfiguration(cfg);
                //IMapper mapper = new Mapper(config); 
                //IncludeDestination includeDestination = mapper.Map<IncludeSource, IncludeDestination>(includeSource);

                #endregion

                #region 反向映射和展平化
                //{
                //    Order order = new Order()
                //    {
                //        Customer = new Customer()
                //        {
                //            Name = "Ricahrd"
                //        }
                //    };
                //    var product = new Product()
                //    {
                //        Price = 5000,
                //        Name = "笔记本"
                //    };
                //    order.AddOrderLineItem(product, 10);
                //    var config = new MapperConfiguration(cfg =>
                //    {
                //        cfg.CreateMap<Order, OrderDto>().ReverseMap();
                //    });
                //    IMapper mapper = config.CreateMapper();
                //    OrderDto orderDto = mapper.Map<Order, OrderDto>(order);
                //    orderDto.CustomerName = "朝夕-Richard";
                //    Order Order1 = mapper.Map<OrderDto, Order>(orderDto);
                //}
                #endregion

                #region 配置验证  
                //{
                //    try
                //    {
                //        //属性A ---属性B 
                //        //var config = new MapperConfiguration(cfg =>
                //        //{
                //        //    cfg.CreateMap<ValdateSource, ValdateDestination>().ReverseMap();
                //        //});
                //        //config.AssertConfigurationIsValid(); //调用此方法即可
                //    }
                //    catch (Exception ex)
                //    {
                //        Console.WriteLine(ex.Message);
                //        throw;
                //    }

                //    {
                //        //忽略
                //        var config = new MapperConfiguration(cfg =>
                //        {
                //            cfg.CreateMap<ValdateSource, ValdateDestination>().ForMember(p => p.SomeValuefff, opt => opt.Ignore());
                //        });
                //        config.AssertConfigurationIsValid();
                //    }

                //    {
                //        var config = new MapperConfiguration(cfg =>
                //        {
                //            cfg.CreateMap<ValdateSource, ValdateDestination>().ForMember(p => p.SomeValuefff, opt => opt.MapFrom(a => a.SomeValue));
                //        });
                //        config.AssertConfigurationIsValid();
                //    }
                //}
                #endregion

                #region 列表和数组 
                //{
                //    var configuration = new MapperConfiguration(cfg => cfg.CreateMap<Source, Dest>());
                //    //Source[] sources = new[]
                //    //    {
                //    //            new Source {  Age=35, Id=123,Name="Eleven" },
                //    //            new Source { Age=33, Id=234,Name="ricahrd" },
                //    //            new Source {  Age=25, Id=345,Name="cole" }
                //    //    };
                //    Source[] sources = null;
                //    IMapper mapper = configuration.CreateMapper();
                //    IEnumerable<Dest> ienumerableDest = mapper.Map<Source[], IEnumerable<Dest>>(sources);
                //    ICollection<Dest> icollectionDest = mapper.Map<Source[], ICollection<Dest>>(sources);
                //    IList<Dest> ilistDest = mapper.Map<Source[], IList<Dest>>(sources);
                //    List<Dest> listDest = mapper.Map<Source[], List<Dest>>(sources);
                //    Dest[] arrayDest = mapper.Map<Source[], Dest[]>(sources);
                //}
                #endregion

                #region 多态元素类型
                //{
                //    var configuration = new MapperConfiguration(c =>
                //    {
                //        c.CreateMap<ParentSource, ParentDestination>()
                //             .Include<ChildSource, ChildDestination>();
                //        c.CreateMap<ChildSource, ChildDestination>();
                //    });
                //    ParentSource[] sources = new[]
                //        {
                //            new ParentSource(),
                //            new ChildSource(),
                //            new ParentSource()
                //        };
                //    IMapper mapper = configuration.CreateMapper();
                //    var destinations = mapper.Map<ParentSource[], ParentDestination[]>(sources);
                //}

                #endregion

                #region 自定义类型转换
                {

                    try
                    {
                        //如果在映射的过程中，有非常多的基础类型转换的应用
                        //扩展： ITypeConverter<string, DateTime>
                        var configuration = new MapperConfiguration(cfg =>
                        {
                            cfg.CreateMap<string, int>().ConvertUsing(s => Convert.ToInt32(s));
                            cfg.CreateMap<string, DateTime>().ConvertUsing(new DateTimeTypeConverter());
                            cfg.CreateMap<string, Type>().ConvertUsing<TypeTypeConverter>();
                            cfg.CreateMap<CustomSource, CustomDestination>();
                        });
                        configuration.AssertConfigurationIsValid();
                        var source = new CustomSource
                        {
                            Value1 = "5",
                            Value2 = "01/01/2000",
                            Value3 = "AutoMapperSamples.GlobalTypeConverters.GlobalTypeConverters+Destination"
                        };
                        IMapper mapper = configuration.CreateMapper();
                        CustomDestination result = mapper.Map<CustomSource, CustomDestination>(source);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw;
                    }
                }
                #endregion

                #region 定制值解析器
                //{
                //    {
                //        var configuration = new MapperConfiguration(cfg =>
                //        {
                //            //cfg.CreateMap<AnalysisResource, AnalysisDestination>().ForMember(p => p.Total, opt => opt.MapFrom(a => a.Value1 + a.Value2));

                //            //cfg.CreateMap<AnalysisResource, AnalysisDestination>().ForMember(p => p.Total, opt => opt.MapFrom<CustomResolver>());

                //            cfg.CreateMap<AnalysisResource, AnalysisDestination>().ForMember(p => p.Total, opt => opt.MapFrom(new CustomResolver()));
                //        });
                //        configuration.AssertConfigurationIsValid();
                //        var source = new AnalysisResource
                //        {
                //            Value1 = 12,
                //            Value2 = 23
                //        };
                //        IMapper mapper = configuration.CreateMapper();
                //        AnalysisDestination result = mapper.Map<AnalysisResource, AnalysisDestination>(source);
                //    }
                //}
                #endregion

                #region 值转换器 
                //{
                //    var configuration = new MapperConfiguration(cfg =>
                //    {
                //        //cfg.CreateMap<ValueOrder, ValueOrderDto>()
                //        //    .ForMember(d => d.StrAmount, opt => opt.MapFrom(p => p.Amount.ToString()));
                //        //    //.ForMember(des => des.Description, opt => opt.NullSubstitute("如果为空就展示为 Test"));

                //        cfg.CreateMap<ValueOrder, ValueOrderDto>()
                //            .ForMember(d => d.StrAmount, opt => opt.ConvertUsing(new CurrencyFormatter(), src => src.Amount));

                //        //cfg.ValueTransformers.Add<string>(val => val + "万元");

                //        cfg.CreateMap<ValueOrderLineItem, OrderLineItemDto>()
                //          .ForMember(d => d.StrPrice, opt => opt.MapFrom(p => p.Price.ToString()));

                //        //cfg.CreateMap<ValueOrderLineItem, OrderLineItemDto>()
                //        //    .ForMember(d => d.StrPrice, opt => opt.ConvertUsing(new CurrencyFormatter(),src=>src.Price));
                //    });
                //    configuration.AssertConfigurationIsValid(); 
                //    IMapper mapper = configuration.CreateMapper();
                //    ValueOrder valueOrder = new ValueOrder()
                //    {
                //        Amount = 10000,
                //        ValueOrderLineItem = new ValueOrderLineItem()
                //        {
                //            Id = 123,
                //            Name = ".Net高级班的Vip课程",
                //            Price = 8888
                //        }
                //    };
                //    ValueOrderDto orderLineItemDto = mapper.Map<ValueOrder, ValueOrderDto>(valueOrder);
                //}

                #endregion

                #region Map Action之前和之后 
                //{
                //    var configuration = new MapperConfiguration(cfg =>
                //    {
                //        cfg.CreateMap<ValueOrder, ValueOrderDto>()
                //            .ForMember(d => d.StrAmount, opt => opt.MapFrom(p => p.Amount.ToString()))
                //            .ForMember(des => des.Description, opt => opt.NullSubstitute("如果为空就展示为 Test")) //如果在源类型里的成员为null的时候，就把值变成自定义的值
                //            .BeforeMap((src, opt) => src.Amount = src.Amount + 1000)
                //            .AfterMap((src, opt) =>
                //            {
                //                src.Amount = src.Amount + 1000;
                //            });
                //        cfg.ValueTransformers.Add<string>(val => val + "万元");
                //        cfg.CreateMap<ValueOrderLineItem, OrderLineItemDto>()
                //          .ForMember(d => d.StrPrice, opt => opt.MapFrom(p => p.Price.ToString()));

                //        //cfg.CreateMap<ValueOrderLineItem, OrderLineItemDto>()
                //        //    .ForMember(d => d.StrPrice, opt => opt.ConvertUsing(new CurrencyFormatter(),src=>src.Price));
                //    });
                //    configuration.AssertConfigurationIsValid();

                //    IMapper mapper = configuration.CreateMapper();
                //    ValueOrder valueOrder = new ValueOrder()
                //    {
                //        Amount = 10000,
                //        //Description = "描述",
                //        ValueOrderLineItem = new ValueOrderLineItem()
                //        {
                //            Id = 123,
                //            Name = ".Net高级班的Vip课程",
                //            Price = 8888
                //        }
                //    };
                //    ValueOrderDto orderLineItemDto = mapper.Map<ValueOrder, ValueOrderDto>(valueOrder);
                //}
                #endregion

                #region IMappingAction 
                //{
                //    var configuration = new MapperConfiguration(cfg =>
                //    {
                //        //cfg.CreateMap<SomePersonObject, SomeOtherPersonObject>()
                //        //    .BeforeMap((src, opt) => src.Name = src.Name + "---测试")
                //        //    .AfterMap((src, opt) => src.Name = src.Name + "---测试");

                //        cfg.CreateMap<SomePersonObject, SomeOtherPersonObject>()
                //              .BeforeMap<NameMeJohnAction>()
                //              .AfterMap<NameMeJohnAction>(); 
                //    });
                //    configuration.AssertConfigurationIsValid();
                //    IMapper mapper = configuration.CreateMapper();
                //    SomePersonObject somePersonObject = new SomePersonObject()
                //    {
                //        Id = 123,
                //        Name = "朝夕教育"
                //    };

                //    SomeOtherPersonObject someOtherPersonObject = mapper.Map<SomePersonObject, SomeOtherPersonObject>(somePersonObject);
                //}
                #endregion

                #region 映射继承
                //{
                //    var configuration = new MapperConfiguration(cfg =>
                //    {
                //        cfg.CreateMap<OrderMaster, OrderDtoMaster>()
                //         .Include<OnlineOrder, OnlineOrderDto>()
                //         .Include<MailOrder, MailOrderDto>();
                //        cfg.CreateMap<OnlineOrder, OnlineOrderDto>();
                //        cfg.CreateMap<MailOrder, MailOrderDto>();
                //    });
                //    configuration.AssertConfigurationIsValid();
                //    OrderMaster order = new OnlineOrder()
                //    {
                //        Id = 1234,
                //        Name = "测试数据"
                //    };
                //    IMapper mapper = new Mapper(configuration);
                //    var mapped = mapper.Map(order, order.GetType(), typeof(OrderDtoMaster)); 
                //    OrderMaster order1 = new MailOrder()
                //    {
                //        Id = 2345,
                //        Name = "测试数据1"
                //    };
                //    var mapped1 = mapper.Map(order1, order1.GetType(), typeof(OrderDtoMaster));
                //}
                #endregion

                #region 字符串转换
                //{
                //    //枚举--字符串--自动转换
                //    var configuration = new MapperConfiguration(cfg =>
                //    {
                //        cfg.CreateMap<CustomOrder, CustomOrderDto>();
                //    });
                //    configuration.AssertConfigurationIsValid();

                //    var orderList = new List<CustomOrder>() {
                //       new CustomOrder(){  OrderType=OrderTypeEnum.FirstOrder },
                //       new CustomOrder(){  OrderType=OrderTypeEnum.SecondOrder }
                //    }.AsQueryable();

                //    var strFirstOrder = OrderTypeEnum.FirstOrder.ToString();
                //    var strSecondOrder = OrderTypeEnum.SecondOrder.ToString();
                //    var orderDtoList = orderList.ProjectTo<CustomOrderDto>(configuration).ToList();
                //}
                #endregion

                #region 配置 
                //{
                //    //动态--直接读取Dll文件（反射）
                //    //var config = new MapperConfiguration(cfg =>
                //    //{ 
                //    //    //cfg.CreateMap<CustomOrder, CustomOrderDto>();
                //    //});

                //    //var myAssembly = Assembly.Load("AutoMapperConfig");
                //    //var config = new MapperConfiguration(cfg =>
                //    //{
                //    //    cfg.AddMaps(myAssembly);
                //    //});

                //    //var config = new MapperConfiguration(cfg =>
                //    //{
                //    //    cfg.AddMaps(new[] {
                //    //        "AutoMapperConfig" 
                //    //    });
                //    //});

                //    var config = new MapperConfiguration(cfg =>
                //    {
                //        cfg.AddMaps(new[] {
                //           typeof(AutoMapperConfig.AutoMapperConfig)
                //        });
                //    });

                //    IMapper mapper = new Mapper(config);
                //    CustomOrder customOrder = new CustomOrder()
                //    {
                //        OrderType = OrderTypeEnum.FirstOrder
                //    };
                //    CustomOrderDto customOrderDto = mapper.Map<CustomOrder, CustomOrderDto>(customOrder);
                //}
                #endregion

                #region 更换字符
                //{
                //    var config = new MapperConfiguration(cfg =>
                //    {
                //       cfg.ReplaceMemberName("Description", "Test");
                //        cfg.CreateMap<CustomOrder, CustomOrderDto>();
                //    });

                //    IMapper mapper = new Mapper(config);
                //    CustomOrder customOrder = new CustomOrder()
                //    {
                //        OrderType = OrderTypeEnum.FirstOrder,
                //        Description = "更换字符"
                //    };
                //    CustomOrderDto customOrderDto = mapper.Map<CustomOrder, CustomOrderDto>(customOrder);
                //}
                #endregion

                #region 识别前后缀
                //{
                //    var config = new MapperConfiguration(cfg =>
                //    {
                //        cfg.ClearPrefixes();
                //        cfg.RecognizePrefixes("Zhaoxi");
                //        cfg.CreateMap<CustomOrder, CustomOrderDto>();
                //    });

                //    IMapper mapper = new Mapper(config);
                //    CustomOrder customOrder = new CustomOrder()
                //    {
                //        OrderType = OrderTypeEnum.FirstOrder,
                //        Description = "更换字符",
                //        ZhaoxiPrefix = "识别前后缀"
                //    };
                //    CustomOrderDto customOrderDto = mapper.Map<CustomOrder, CustomOrderDto>(customOrder);
                //}
                #endregion

                #region 特性映射
                //{
                //    {
                //        //var config = new MapperConfiguration(cfg =>
                //        //{
                //        //    cfg.CreateMap<CustomOrder, CustomOrderDto>();
                //        //});
                //        //IMapper mapper = new Mapper(config);
                //        //CustomOrder customOrder = new CustomOrder()
                //        //{
                //        //    OrderType = OrderTypeEnum.FirstOrder,
                //        //    Description = "描述信息"
                //        //};
                //        //CustomOrderDto customOrderDto = mapper.Map<CustomOrder, CustomOrderDto>(customOrder);
                //    }
                //    { //特性映射

                //        var config = new MapperConfiguration(cfg =>
                //        {
                //            cfg.AddMaps(typeof(CustomOrderDto));
                //        });

                //        IMapper mapper = new Mapper(config);
                //        CustomOrder customOrder = new CustomOrder()
                //        {
                //            OrderType = OrderTypeEnum.FirstOrder,
                //            Remark = "描述信息",
                //            Prefix = "Prefix"
                //        };
                //        CustomOrderDto customOrderDto = mapper.Map<CustomOrder, CustomOrderDto>(customOrder);

                //    }
                //}
                #endregion

                #region 条件映射
                //{
                //    var config = new MapperConfiguration(cfg =>
                //    {
                //        cfg.CreateMap<CustomOrder, CustomOrderDto>()
                //        .ForMember(d => d.Description, opt => opt.Condition(a => a.Description.Contains("条件映射")))
                //        .ForMember(d => d.Id, opt => opt.Condition(a => a.Id > 10));
                //    });
                //    IMapper mapper = new Mapper(config);
                //    CustomOrder customOrder = new CustomOrder()
                //    {
                //        OrderType = OrderTypeEnum.FirstOrder,
                //        Description = "条件映射",
                //        Id = 11
                //    };
                //    CustomOrderDto customOrderDto = mapper.Map<CustomOrder, CustomOrderDto>(customOrder);
                //}
                #endregion

                #region 泛型映射 
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap(typeof(GenericResult<>), typeof(GenericResultDto<>));
                    });
                    IMapper mapper = new Mapper(config);
                    GenericResult<CustomOrder> genericResult = new GenericResult<CustomOrder>()
                    {
                        Value = new CustomOrder()
                        {
                            OrderType = OrderTypeEnum.FirstOrder,
                            Description = "泛型映射",
                            Id=11,
                            Prefix= "Prefix"
                        }
                    };
                    GenericResultDto<CustomOrder> customOrderDto = mapper.Map<GenericResult<CustomOrder>, GenericResultDto<CustomOrder>>(genericResult);
                }
                #endregion


                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
