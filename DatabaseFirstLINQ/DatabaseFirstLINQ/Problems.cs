﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DatabaseFirstLINQ.Models;

namespace DatabaseFirstLINQ
{
    class Problems
    {
        private ECommerceContext _context;

        public Problems()
        {
            _context = new ECommerceContext();
        }
        public void RunLINQQueries()
        {
            ProblemOne();
            //ProblemTwo();
            //ProblemThree();
            //ProblemFour();
            //ProblemFive();
            //ProblemSix();
            //ProblemSeven();
            //ProblemEight();
            //ProblemNine();
            //ProblemTen();
            //ProblemEleven();
            //ProblemTwelve();
            //ProblemThirteen();
            //ProblemFourteen();
            //ProblemFifteen();
            //ProblemSixteen();
            //ProblemSeventeen();
            //ProblemEighteen();
            //ProblemNineteen();
            //ProblemTwenty();
            //BonusOne()
            BonusThree();
            //BonusOne();
            //BonusTwo();
        }

        // <><><><><><><><> R Actions(Read) <><><><><><><><><>
        private void ProblemOne()
        {
            int userList = _context.Users.ToList().Count;
            Console.WriteLine(userList);
            Console.WriteLine("========");


        }

        //private void ProblemTwo()
        //{

        //    var users = _context.Users;

        //    foreach (User user in users)
        //    {
        //        Console.WriteLine(user.Email);
        //    }

        //}

        //private void ProblemThree()
        //{
        //    var productsOver = _context.Products.Where(p => p.Price > 150);
        //    foreach (Product product in productsOver)
        //    {
        //        Console.WriteLine(product.Name);
        //    }

        //    // Write a LINQ query that gets each product where the products price is greater than $150.
        //    // Then print the name and price of each product from the above query to the console.

        //}

        //private void ProblemFour()
        //{
        //    var productsWithS = _context.Products.Where(p => p.Name.Contains("s"));
        //    foreach (Product product in productsWithS)
        //    {
        //        Console.WriteLine(product.Name);
        //    }

        //}
        //private void ProblemFive()
        //{
        //    var usersBeforeDate = _context.Users.Where(u => u.RegistrationDate < DateTime.Parse("01/01/2016").Date);

        //    foreach (User user in usersBeforeDate)
        //    {

        //        Console.WriteLine($"Email: {user.Email} Registration date: {user.RegistrationDate}");

        //    }



        //    //    Write a LINQ query that gets all of the users who registered BEFORE 2016
        //    //     Then print each user's email and registration date to the console.

        //}


        //private void ProblemSix()
        //{

        //    var usersBeforeDate = _context.Users.Where(u => u.RegistrationDate > DateTime.Parse("12/31/2016").Date && u.RegistrationDate < DateTime.Parse("01/01/2018").Date);

        //    foreach (User user in usersBeforeDate)
        //    {
        //        Console.WriteLine($"Email: {user.Email} Registration date: {user.RegistrationDate}");
        //    }

        //    //    Write a LINQ query that gets all of the users who registered AFTER 2016 and BEFORE 2018
        //    //     Then print each user's email and registration date to the console.

        //}

        // <><><><><><><><> R Actions(Read) with Foreign Keys<><><><><><><><><>

        //private void ProblemSeven()
        //{
        //    //Write a LINQ query that retreives all of the users who are assigned to the role of Customer.        
        //    //     Then print the users email and role name to the console.
        //    var customerUsers = _context.UserRoles.Include(ur => ur.Role).Include(ur => ur.User).Where(ur => ur.Role.RoleName == "Customer");
        //    foreach (UserRole userRole in customerUsers)
        //    {
        //        Console.WriteLine($"Email: {userRole.User.Email} Role: {userRole.Role.RoleName}");
        //    }
        //}

        //private void ProblemEight()
        //{
        //    //Write a LINQ query that retreives all of the products in the shopping cart of the user who has the email "afton@gmail.com".
        //    // Then print the product's name, price, and quantity to the console.

        //    var productsOfUser = _context.ShoppingCarts.Include(sc => sc.Product).Where(sc => sc.User.Email == "afton@gmail.com");


        //    foreach (var product in productsOfUser)
        //    {

        //        Console.WriteLine($"name: {product.Product.Name} Price {product.Product.Price} Quantity {product.Quantity}");
        //    }
        //}

        //private void ProblemNine()
        //{
        //    //Write a LINQ query that retreives all of the products in the shopping cart of the user who has the email "oda@gmail.com" and returns the sum of all of the products prices.
        //    // HINT: End of query will be: .Select(sc => sc.Product.Price).Sum();
        //    //Then print the total of the shopping cart to the console.
        //    var productsToSum = _context.ShoppingCarts.Include(sc => sc.Product).Where(sc => sc.User.Email == "oda@gmail.com").Select(sc => sc.Product.Price).Sum(); 
        //    Console.WriteLine(productsToSum);



        //}

        private void ProblemTen()
        {
            //Write a LINQ query that retreives all of the products in the shopping cart of users who have the role of "Employee".
            // Then print the user's email as well as the product's name, price, and quantity to the console.
            {
                //Write a LINQ query that retreives all of the products in the shopping cart of users who have the role of "Employee".
                // Then print the user's email as well as the product's name, price, and quantity to the console.

                var roleType = _context.Roles.Where(r => r.RoleName == "Employee").Include(r => r.UserRoles);
                var products = _context.ShoppingCarts.Include(sc => sc.Product).Where(sc => sc.User.UserRoles == roleType).Select(sc => sc.Product);


                foreach (Product product in products)
                {
                    Console.WriteLine(product.Name);
                }


                //    // <><><><><><><><> CUD(Create, Update, Delete) Actions<><><><><><><><><>

                //    // <><> C Actions(Create) <><>
                //}
                ////private void ProblemEleven()
                //{
                //    //Create a new User object and add that user to the Users table using LINQ.
                //    User newUser = new User()
                //    {
                //        Email = "david@gmail.com",
                //        Password = "DavidsPass123"
                //    };
                //    _context.Users.Add(newUser);
                //    _context.SaveChanges();
                //}

                //private void ProblemTwelve()
                //{
                //    //    Create a new Product object and add that product to the Products table using LINQ.
                //    Product product = new Product()
                //    {
                //        Name = "Tablet",
                //        Description = "Apple Ipad 32 GB",
                //        Price = 700
                //    };
                //    _context.Products.Add(product);
                //    _context.SaveChanges();

                //}

                //private void ProblemThirteen()
                //{
                //    //Add the role of "Customer" to the user we just created in the UserRoles junction table using LINQ.
                //    var roleId = _context.Roles.Where(r => r.RoleName == "Customer").Select(r => r.Id).SingleOrDefault();
                //    var userId = _context.Users.Where(u => u.Email == "david@gmail.com").Select(u => u.Id).SingleOrDefault();
                //    UserRole newUserRole = new UserRole()
                //    {
                //        UserId = userId,
                //        RoleId = roleId
                //    };
                //    _context.UserRoles.Add(newUserRole);
                //    _context.SaveChanges();
                //}

                //private void ProblemFourteen()
                //{
                //    //Add the product you create to the user we created in the ShoppingCart junction table using LINQ.
                //    var productId = _context.Products.Where(p => p.Name == "Tablet").Select(p => p.Id).SingleOrDefault();
                //    var userId = _context.Users.Where(u => u.Email == "oda@gmail.com").Select(u => u.Id).SingleOrDefault();
                //    ShoppingCart newShoppingCart = new ShoppingCart()
                //    {
                //        UserId = userId,
                //        ProductId = productId,
                //        Quantity = 1
                //    };
                //    _context.ShoppingCarts.Add(newShoppingCart);
                //    _context.SaveChanges();
                //}

                // <><> U Actions(Update) <><>

                //private void ProblemFifteen()
                //{
                //    //Update the email of the user we created to "mike@gmail.com"
                //    var user = _context.Users.Where(u => u.Email == "david@gmail.com").SingleOrDefault();
                //    user.Email = "mike@gmail.com";
                //    _context.Users.Update(user);
                //    _context.SaveChanges();
                //}

                //private void ProblemSixteen()
                //{
                //    //Update the price of the product you created to something different using LINQ.

                //    var productToUpdate = _context.Products.Where(p => p.Id == 8).SingleOrDefault();

                //    productToUpdate.Price = 1050;

                //    _context.Products.Update(productToUpdate);
                //    _context.SaveChanges();
                //}

                //private void ProblemSeventeen()
                //{
                //    //Change the role of the user we created to "Employee"
                //    // HINT: You need to delete the existing role relationship and then create a new UserRole object and add it to the UserRoles table
                //    // See problem eighteen as an example of removing a role relationship
                //    var userRole = _context.UserRoles.Where(ur => ur.User.Email == "mike@gmail.com").SingleOrDefault();
                //    _context.UserRoles.Remove(userRole);
                //    UserRole newUserRole = new UserRole()
                //    {
                //        UserId = _context.Users.Where(u => u.Email == "mike@gmail.com").Select(u => u.Id).SingleOrDefault(),
                //        RoleId = _context.Roles.Where(r => r.RoleName == "Employee").Select(r => r.Id).SingleOrDefault()
                //    };
                //    _context.UserRoles.Add(newUserRole);
                //    _context.SaveChanges();
                //}

                //<><> D Actions(Delete) <><>

                //private void ProblemEighteen()
                //{
                //    Console.WriteLine("success!");
                //    //Delete the role relationship from the user who has the email "oda@gmail.com" using LINQ.
                //    var userRole = _context.UserRoles.Where(ur => ur.User.Email == "afton@gmail.com").SingleOrDefault();

                //    _context.UserRoles.Remove(userRole);
                //    _context.SaveChanges();


                //}




                //private void ProblemNineteen()
                //{
                //    //Delete all of the product relationships to the user with the email "oda@gmail.com" in the ShoppingCart table using LINQ.
                //    //HINT: Loop
                //   var shoppingCartProducts = _context.ShoppingCarts.Where(sc => sc.User.Email == "oda@gmail.com");
                //    foreach (ShoppingCart userProductRelationship in shoppingCartProducts)
                //    {
                //        _context.ShoppingCarts.Remove(userProductRelationship);
                //    }
                //    _context.SaveChanges();
                //}

                //private void ProblemTwenty()
                //{
                //    //Delete the user with the email "oda@gmail.com" from the Users table using LINQ.

                //    var userToDelete = _context.Users.Where(u => u.Email == "oda@gmail.com").SingleOrDefault();
                //    Console.WriteLine("========");
                //    Console.WriteLine(userToDelete);

                //    _context.Users.Remove(userToDelete);
                //    _context.SaveChanges();

                //}

                //        // <><><><><><><><> BONUS PROBLEMS<><><><><><><><><>

                //        private void BonusOne()
                //{
                //    //Prompt the user to enter in an email and password through the console.
                //    // Take the email and password and check if the there is a person that matches that combination.
                //    // Print "Signed In!" to the console if they exists and the values match otherwise print "Invalid Email or Password."

                //    Console.WriteLine("Enter email:");
                //    string userEmail = Console.ReadLine();

                //    Console.WriteLine("Enter password:");
                //    string userPassword = Console.ReadLine();

                //    if (_context.Users.Count((u) => u.Email == userEmail && u.Password == userPassword) == 0)
                //    {
                //        Console.WriteLine("Invalid Email or Password.");
                //    }
                //    else
                //    {
                //        Console.WriteLine("Signed In!");
                //    }

                //}

                private void BonusTwo()
        {
            int grandTotal = 0;

            Console.WriteLine(grandTotal);

            var users = _context.Users.ToList();
            foreach (var user in users)
            {
                var shoppingCart = _context.ShoppingCarts.Where(sc => sc.UserId == user.Id).Select(sc => sc.Product.Price);
                var quatity = _context.ShoppingCarts.Where(sc => sc.UserId == user.Id).Select(sc => sc.Quantity);
                Console.WriteLine(quatity.Count());


                foreach (var shoppingCartItem in shoppingCart)
                {
                    Console.WriteLine("=======");
                    Console.WriteLine(user.Email);
                    Console.WriteLine(shoppingCartItem);

                }

            }
        }
        //Write a query that finds the total of every users shopping cart products using LINQ.
        //Display the total of each users shopping cart as well as the total of the toals to the console.
    }

        //BIG ONE
        private void BonusThree()
        {
            // 1.Create functionality for a user to sign in via the console


            Console.WriteLine("Please Enter Your Email: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Please Enter Your Password: ");
            string password = Console.ReadLine();

            if (_context.Users.Count(u => u.Email == userName && u.Password == password) == 0)
            {
                Console.WriteLine("Invalid Username or Password! Please try again.");
            }
            else
            {
                Console.WriteLine("You are signed in! Please select an option: (1) View Cart (2) View All Products (3) Add to Cart (4) Remove from Cart");
                string userOption = Console.ReadLine();
                if (userOption == "1")
                {

                    var cart = _context.Users.Include(u => u.ShoppingCarts).Where(u => u.Email == userName).Select(u => u.ShoppingCarts).SingleOrDefault();
                    var products = cart.Select(cart => cart.Product);
                    foreach(Product product in products)
                    {
                        Console.WriteLine(product.Name);
                    }
                }
                else
                {
                    Console.WriteLine("success!!");
                }
            }
            

            //2.If the user succesfully signs in
        //        var employees = _context.UserRoles.Where(ur => ur.Role.RoleName == "Employee").Select(ur => ur.User.Id);



        //        foreach (var employee in employees)
        //        {
        //            var carts = _context.ShoppingCarts.Include(sc => sc.Product).Where(sc => sc.User.Id.Equals(employee));
        //            Console.WriteLine(carts);
        //        }
        //    }


            //a.Give them a menu where they perform the following actions within the console


            //View the products in their shopping cart


            //View all products in the Products table


            //Add a product to the shopping cart(incrementing quantity if that product is already in their shopping cart)
            //      Remove a product from their shopping cart
            //      3.If the user does not succesfully sing in
            //      a.Display "Invalid Email or Password"
            //      b.Re - prompt the user for credentials

        }

    }
    }


    
