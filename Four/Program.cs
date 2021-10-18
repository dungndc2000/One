using Four.Entity;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Four
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.OutputEncoding = Encoding.UTF8;

            var context = new DbContextFour();

            var Productinvoice1 = (from Product in context.Products
                                   join idt in context.DetailsInvoices on Product.Id equals idt.ProductID
                                   join invoice in context.Invoices on idt.InvoiceID equals invoice.Id
                                   where Product.Name == "Bánh xốp Luxury"
                                   select new ProductInvoice
                                   {
                                       ProductId = Product.Id,
                                       InvoiceId = invoice.Id,
                                       ProductName = Product.Name,
                                       InvoicePrice = invoice.Price,
                                       DetailsInvoiceCount = idt.Count
                                   }).AsNoTracking().ToList();
            foreach (var item in Productinvoice1)
            {
                Console.WriteLine("Ten la:{0}", item.ProductName);
                Console.WriteLine("Gia la:{0}", item.InvoicePrice);
                Console.WriteLine("So luong la:{0}", item.DetailsInvoiceCount);
            }
            // in ra giá,số lượng của người có tên Chí phèo

            var PriceCount = (from Customer in context.Customers
                              join inv in context.Invoices on Customer.Id equals inv.Id
                              join detain in context.DetailsInvoices on inv.Id equals detain.Id
                              where Customer.Name == "Chí Phèo"
                              select new FindCusstomer
                              {
                                  CustomerID = Customer.Id,
                                  InvoiceID = inv.Id,
                                  Price = inv.Price,
                                  Count = detain.Count,
                                  Address = Customer.Address
                              }
                              ).AsNoTracking().ToList();


            foreach (var item in PriceCount)
            {
                Console.WriteLine("Dia chi la:" + item.Address);
                Console.WriteLine("So luong la:" + item.Count);
                Console.WriteLine("Gia la:" + item.Price);
                Console.WriteLine("=============");
            }

            var TestGroupBy121 = from c in PriceCount
                                 group c by c.CustomerID;
            

            var Orderbyyy = from c in context.Customers
                            orderby c.Id descending
                            select c;
            foreach (var item in Orderbyyy)
            {
                Console.WriteLine(item.Id);
            }

            //foreach (var item in testgroupby121)
            //{
            //    console.writeline(item.key);
            //    foreach (var item1 in item)
            //    {
            //        console.writeline(item1.address);
            //    }
            //}
            //#region groupby query syntax
            //var tetgb = (from cu in context.customers
            //             select new testgroupby
            //             {
            //                 customerid = cu.id,
            //                 customername = cu.name,
            //                 address = cu.address,
            //                 dateofbirth = cu.dateofbirth
            //             }
            //             ).asnotracking().tolist();
            //var tetgb = from c in tetgb
            //            group c by c.customerid;

            //foreach (var item in tetgb)
            //{
            //    console.write(item.key);

            //    foreach (var item1 in item)
            //    {                    
            //        console.writeline(item1.customername);
            //    }
            //}
            //#endregion
            //#region top1
            //var namecustomer = context.customers.where(c => c.name == "chí phèo").firstordefault();//k bắn ra excaption
            //console.writeline("thông tin của người có tên {0} là: giới tính: {1},ngày sinh:{2} ", namecustomer.name, namecustomer.gender, namecustomer.dateofbirth);

            //string name = "thúy thị vân";
            //var nameone = context.customers.where(c => c.name == name).firstordefault();
            //console.writeline("thông tin của người có tên {0} là: giới tính: {1},ngày sinh:{2} ", nameone.name, nameone.gender, nameone.dateofbirth);
            //#endregion
            //#region list
            //var findprice = context.invoices.where(i => i.price > 25000).tolist();
            //foreach (var item in findprice)
            //{
            //    console.writeline("những mệnh giá lớn hơn 25000 là : {0}", item.price);
            //    console.writeline("--------------");
            //}
            //var studentswithsamename = context.customers
            //                                 .where(s => s.gender == enum.gender.male)
            //                                 .tolist();
            //foreach (var item in studentswithsamename)
            //{
            //    console.writeline("name: {0}  gender: {1}  dateofbirth:  {2}", item.name, item.gender, item.dateofbirth);
            //    console.writeline("----------------------------------------------");
            //}

            //#endregion
            //#region groupby
            //var testgroupby1 = context.customers.groupby(c => c.id).tolist();
            //foreach (var groupitem in testgroupby1)
            //{
            //    console.write(groupitem.key + "  ");

            //    foreach (var item1 in groupitem)
            //    {
            //        console.writeline(item1.name);
            //    }
            //}
            //#endregion
            //#region orderby

            //var testorderby = context.customers.orderbydescending(s => s.id).tolist();
            //foreach (var item in testorderby)
            //{
            //    console.writeline(item.id);
            //}

            //#endregion
            //#region anonymous
            //console.writeline("------------------------");
            //var anonymousobjresult = context.customers
            //                    .where(st => st.id == 1)
            //                    .select(st => new
            //                    {
            //                        id = st.id,
            //                        name = st.name
            //                    });


            //foreach (var obj in anonymousobjresult)
            //{
            //    console.writeline(obj.name);
            //}
            //#endregion



        }
    }
}



