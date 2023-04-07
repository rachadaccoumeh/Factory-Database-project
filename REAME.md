# Factory Database Project

This is a database project for a fictional factory that produces various products. The project is designed to manage the
factory's production process, including the products, suppliers, customers, orders, employees, meals, and daily
production.

## Features

- Products: Add, edit, and delete products.
- Suppliers: Add, edit, and delete suppliers.
- Customers: Add, edit, and delete customers.
- Orders: Add, edit, and delete orders.
- Employees: Add, edit, and delete employees.
- Meals: Add, edit, and delete meals.
- Daily Production: Record daily production of meals.
- Material Warnings: Warns when material is low.

## Getting Started

### Prerequisites

- Microsoft SQL Server installed
- Microsoft SQL Server Management Studio installed
- Visual Studio installed
- .NET Framework installed
- Crystal Reports installed

### Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/rachadaccoumeh/Factory-Database-project.git
     ```
2. Create a Microsoft SQL Server database and import the `sales.sql` file located in the `sql` folder.
3. Update the `app.config` file with your database credentials.
4. Open the `FactoryDatabase` solution in Visual Studio.
5. Build and run the application.

## Usage

The application will start and prompt you to enter your username and password. Once authenticated, you will have access
to the main menu where you can navigate through the different features.

To create an invoice for an order, you can use Crystal Reports. After selecting an order to create an invoice for, click
on the "Create Invoice" button to generate a Crystal Report for the invoice. You can then print or save the invoice as a
PDF file.

To record daily production of meals, go to the Daily Production menu and select the meal to record production for. Enter
the production details and click on the "Save" button to save the production record.

The system will warn you when material is low. If the quantity of a material is less than or equal to the minimum
quantity set for that material, a warning message will be displayed.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request if you would like to contribute.