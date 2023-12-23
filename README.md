# Book-Shop-API
Bu Proje bir kitap satış sitesinin genel back end işlemlerini gerçekleştirmek için yazılmıştır.<br />
Proje Onion Architecture ile geliştirilmiştir, içerisinde CQRS pattern kullanılmış olup çok fazla tekrarlanan veriler Redis ile cache'lenmiştir. <br />
Hatalar ve genel işlemler ise Serilog ile hem dosyaya hem de veritabanına loglanmış olup önemli hatalar ise json formatta bir dosyaya ayrıca loglanmaktadır.<br />
Projede kullanılan kütüphaneler ise ;<br />
* MediatR
* MediatR.Extensions.Microsoft.DependencyInjection
* AutoMapper
* AutoMapper.Extensions.Microsoft.DependencyInjection
* FluentValidation
* FluentValidation.AspNetCore
* Microsoft.EntityFrameworkCore
* Microsoft.EntityFrameworkCore.SqlServer
* Microsoft.EntityFrameworkCore.Tools
* Microsoft.Extensions.Caching.StackExchangeRedis
* MailKit
* Otp.NET
* Serilog
* Serilog.AspNetCore
* Serilog.Sinks.File
* Serilog.Sinks.MSSqlServer
* System.IdentityModel.Tokens.Jwt
* Microsoft.AspNetCore.Authentication.JwtBearer

Projenin veritabanı diagrami ise şu şekildedir ;
![DataBaseDiagram](https://github.com/Nihat-Yildirim/Book-Shop-API/assets/124464907/5c06df3a-b8d3-457f-ae1b-7a970bf65090)
