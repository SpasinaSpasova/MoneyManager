# MoneyManager
## Overview
Money manager is a final project to complete a training course ASP.NET Core Advanced in Software University. The application is easy to use and has a simple user-friendly interface. The main functionality of Money manager is to track all of your expenses and incomes by categories, and accounts. If you want to join the app, you have to register first and after that login. You can **add, edit, delete and upload image** to current income and expenses. But before you have to add incomes or expenses, you need to **add account** from which to take money or in which to save money. Categories in application **depends on** income and expense. You also can add new type ot categories. For more comfrot view of your finances you can view the **statistic dashboard**. You have access to **edit and delete** accounts, but only have access to edit incomes and expenses categories, you can not delete it. **Note** that the admin only can delete any category. Admin also is user and can add, remove and edit incomes, expenses, accounts and categories and view own statistic board.
## Programming languages, technologies, libraries and frameworks:
- C#, JavaScript
- ASP.NET Core 6.0, Entity Framework Core 6.0.1
- MSSQL 2019, VS22
- Bootstrap, HTML 5 Canvas
## Application Flow
When the user or admin starts the app he's redirected to the home page.

![This is a home image](https://github.com/SpasinaSpasova/MoneyManager/blob/main/Screenshots/home.png)

The navbar has three buttons for login and register, which loads the login and register form. 
Login form asks for the user's username and password. 
The register form asks for:Username, First name, Last name, Email Address, Password,Confirm Password.
After successful registration, the user is redirected to login page.

![This is a login and register image](https://github.com/SpasinaSpasova/MoneyManager/blob/main/Screenshots/login_register.png)

After successful login, the user is redirected to the statistic board.

![This is a statistic board image](https://github.com/SpasinaSpasova/MoneyManager/blob/main/Screenshots/user_dashboard.png)

If the loged user is admin, he is redirect to the admin home page which look like:

![This is a admin home image](https://github.com/SpasinaSpasova/MoneyManager/blob/main/Screenshots/admin_home.png)

The navbar for users content these buttons: Incomes, Expenses, Accounts, Income Categories and Expense Categories.

The "Incomes" buttons shows all incomes for current user.

![This is all incomes image](https://github.com/SpasinaSpasova/MoneyManager/blob/main/Screenshots/AllIncomes.png)

The user can edit, delete and upload image to an income with buttons "Edit", "Delete", "Choose file" and "Upload Income Image".
With button "Add New Income" user is redirect to page in which should fill in the information for add new income. If the user wants, he can add new category or new account after clicking the buttons in this form- he is redirect to other pages.

![This is add incomes image](https://github.com/SpasinaSpasova/MoneyManager/blob/main/Screenshots/AddIncome.png)

Here is the other pages:

![This is add category image](https://github.com/SpasinaSpasova/MoneyManager/blob/main/Screenshots/AddCategoryIncome.png)

![This is add account image](https://github.com/SpasinaSpasova/MoneyManager/blob/main/Screenshots/AddAccount.png)

- After successful adding of new income the user is redirect to all incomes.
- After successful adding of new category income the user is redirect to all income categories.
- After successful adding of new account the user is redirect to all accounts.


**The functionallity for expenses is same as the incomes! With small difference between  the redirecting of the pages.**
