The Food Ordering System will include the following modules:

Staff Management Module: Staff members are required to log in for authentication and authorization to manage restaurant operations. This module will maintain staff personal information, login and logout activities, and assign roles such as cashier, kitchen staff, or waiters. Only administrators have the privilege to add staff and update their statuses.

Order Management Module: This module will allow staff to manage customer orders efficiently. It will support order placement, tracking, updating order statuses (e.g., pending, in progress, completed), and ensuring accurate food preparation and delivery.

Billing & Payment Module: This module will handle financial transactions, ensuring a seamless payment process. It will support various payment methods such as cash or E-wallet payments while also generating invoices and receipts.

Item Stock Management Module: This module will enable staff to monitor and manage food freshness and inventory levels. It will track stock usage, notify staff when supplies are low, and help prevent shortages or overstocking.

Only administrators will have the privilege to generate reports such as sales summaries, order history, stock updates, and staff performance analysis. Certain reports will be restricted for business confidentiality.

Overall, the proposed Food Ordering System will serve as an all-in-one solution for restaurant management, enhancing efficiency in daily operations. All modules include Create, Retrieve, Update, and Delete (CRUD) functions, allowing staff to easily manage records as needed. This system will improve workflow, minimize errors, and optimize service delivery.

Staff Module
------------
User authentication and authorization : 
This function is used to make sure the administrator enters the correct username and password to log in and to prevent staff and other people from logging in.

Add new staff : 
This function allows administrators to hire new staff in the system. To create a staff’s record, relevant staff information such as name, contact number, email address, home address, relevant role in the restaurant, and so on are required.

View staff information : 
In this function, administrators can view and access the staff’s information in the system. The system will display all the staff’s names and the administrator can view their information by clicking one of their names.

Update staff’s personal information : 
Administrator’s are able to update and modify staff’s personal information. When the staff change one of the information in their own profile, the system will automatically update and changes will be applied.

Delete staff record : 
This function allows the administrator to remove staff’s record which includes all of their information from the system. The administrator should use the delete function in caution because deleted records cannot be retrieved. A warning message will appear before they delete the respective staff’s information just in case there is a change of mind.

Staff report : 
This function will generate a staff report by displaying the staff’s name list, with their personal information and their respective role in the restaurant.

Order management Module
-----------------------
Add new order : 
The create function is mainly used for adding new customer orders to the system, handled by cashiers. To create a new order, relevant information such as customer details (if applicable), selected food items, quantity, and payment method must be recorded. Once an order is placed, it is sent to the kitchen for preparation.

Read order record (View order details) : 
The read function allows cashiers, waiters, and administrators to view and access order records in the system. Orders can be searched using an order ID or order status (e.g., pending, in progress, completed). This function ensures real-time visibility of ongoing and past orders.

Update order information : 
The update function enables staff to modify order details when necessary. For example, if a customer requests to change an order (e.g., adding or removing items), the staff can update the order before it is processed. Additionally, the order status can be updated (e.g., "Pending," "Preparing," "Completed").

Delete order record (Cancel order) : 
The delete function allows staff to cancel an order if a customer changes their mind or due to unforeseen circumstances. However, cancellations should be done cautiously as they may affect inventory and sales records. Once an order is canceled, it cannot be retrieved.

Track order status : 
This function helps staff track real-time order statuses such as "Pending," "In Preparation," or "Completed." This allows kitchen staff to manage their workflow efficiently and ensures customers know timely updates about their orders.

Order report : 
This feature generates order reports, displaying details such as total orders, sales revenue, popular food items, and pending/canceled orders over a specific period(if applicable). Administrators can use these reports for business analysis and decision-making to improve restaurant performance.

Billing and Payment Module
--------------------------
Create and calculate customers’ bill : 
Each time a customer places an order, the system will automatically generate a bill based on the total price of the ordered items, including applicable taxes and discounts. If a customer adds more items to an ongoing order, the bill will be updated accordingly. 

Display customer’s bill : 
This function displays a list of all orders along with their billing status (e.g., "Pending," "Paid," "Cancelled"). The administrator can access detailed billing information, including the breakdown of items, total amount, and applied discounts(if applicable).

Payment processing and Updating bill status : 
The system supports multiple payment methods, including cash, and E-wallet payments. For each payment, the cashier or administrator will manually enter the amount paid. After successful payment, the bill status updates from "Pending" to "Paid." If an order is canceled, the payment status will be updated to "Cancelled". Unpaid orders beyond a certain time limit may be flagged as an escaped bill for review or cancellation.


Generate payment reports : 
Payment reports are generated on a daily, weekly, or monthly basis to track restaurant revenue. Only the administrator can view different financial reports, such as:
Sales Summary Report – Overview of total revenue generated.
Transaction History Report – Record of all completed transactions.
Cancellation Report – Details of canceled orders.

Item Stock Module
-----------------
Add new stock item : 
The create function is used for adding new stock items to the system, handled by administrators. To add a new item, relevant details such as item name, category, quantity, and unit price must be recorded. Once added, stock levels will be automatically updated as items are ordered by customers.

View stock records : 
The read function allows waiters and administrators to view and access stock records in the system. Items can be searched using item name, category, or stock level (e.g., low stock, available, out of stock). This function ensures real-time visibility of current inventory levels.

Update stock information : 
The update function enables staff to modify stock details when necessary. For example, if the chef has prepared an extra quantity of the food, the stock can be updated accordingly. If certain food is not fresh, the stock will be decreased as well.

Delete item record (Remove stock item) : 
The delete function allows staff to remove stock items that are expired, damaged, or no longer needed. However, stock removal should be done cautiously, as it may affect inventory records and cost calculations. Once an item is removed, it cannot be retrieved.

Track stock levels : 
This function helps staff track real-time stock levels and pop up alert messages when items are running low while ordering. It ensures that every food type is replenished in time to prevent shortages and avoid any wastage.

Stock report : 
This function generates stock reports, displaying details such as current stock levels, usage history, and wasted items. Administrators can use these reports for inventory planning and cost management to improve restaurant efficiency.
