
![KaleMeCrazyLogo](/Images/KaleMeCrazyLogoFinal.png)

*All instruction s for this projct are realated to GitHub, Visual Studio Community, PostMan, and C#.*
### How to run locally

#### Dowload or Clone  the project from: https://github.com/C-Goodwin/KaleMeCrazy

* **First** Open the code in Visual Stuio Community
* **Second** Select Control+ Shit = B to build the code
* **Third** Resolve any errorsthat may have occured 
* **Fourth** Start the code and open the APIin your browser
* **Fith** Open PostMan to test your endpoints
* **Sixth** Ensure you can see all endpoints in the API
* **Seventh** more instructions


### Test Shop

*To completely test the shop CRUD in Postman you will need to validate the "Body" of each method. When making changes to the shop object you will need to specify the ID before updating or deleting any existing shop object.*

* **Register A Shop** Post: https://localhost:44382/api/account/register

* **Get Bearer Token** Get:https://localhost:44382/token

* **Get A Shop** Get: https://localhost:44382/api/shop

* **Get A Shop By ID** https://localhost:44382/api/shop/1

* **Create A Shop** Post: https://localhost:44382/api/shop

* **Update A Shop** Put: https://localhost:44382/api/shop

* **Delete A Shop** Delete: https://localhost:44382/api/shop/3

### Test Menu

*To completely test the Menu CRUD in Postman you will need to validate the "Body" of each method.  When making changes to the Menu object you will need to specify the ID or ID's needed before getting, updating, or deleting any existing Menu object. If creating a Menu object, a unique ID will be automatically generated within entity framework.*

* **Register A User** POST: {localhost}/api/account/register 

* **Get Bearer Token** GET: {localhost}/token

* **Create Menu** POST: {localhost}/api/Menu
  * Must include in body

      | Key    | Value       |
      |--------|-------------|
      | ShopId | id/int      |
      | Name   | name/string |

* **Get Menus For ALL Shops** GET: {localhost}/api/Menu

* **Get Menus For ONE Shop** GET: {localhost}/api/Menu?ShopId={id}
  * Must include {ShopId} at end of url

* **Get ONE Menu By Id** GET: {localhost}/api/Menu/{id}
  * Must include {MenuId} at end of url

* **Update Menu** PUT: {localhost}/api/Menu/{id}
  * Must include in body

      | Key    | Value       |
      |--------|-------------|
      | MenuId | id/int      |
      | Name   | name/string |

* **Delete Menu** DELETE: {localhost}/api/Menu/{id}
  * Must include {MenuId} at end of url

### Test MenuItem

*To completely test the MenuItem CRUD in Postman you will need to validate the "Body" of each method.  When making changes to the MenuItm object you will need to specify the ID or ID's needed before getting, updating, or deleting any existing MenuItem object. If creating a MenuItem object, a unique ID will be automatically generated within entity framework.*

* **Register A User** POST: {localhost}/api/account/register 

* **Get Bearer Token** GET: {localhost}/token

* **Create MenuItem** POST: {localhost}/api/MenuItem
  * Must include in body

      | Key         | Value              |
      |-------------|--------------------|
      | ItemId      | id/int             |
      | ItemName    | name/string        |
      | Description | description/string |
      | Price       | price/double       |

* **Get MenuItems For ALL Menus** GET: {localhost}/api/MenuItem

* **Get MenuItems For ONE Menu** GET: {localhost}/api/MenuItem?menuId={id}
  * Must include {MenuId} at end of url

* **Get ONE MenuItem By Id** GET: {localhost}/api/MenuItem?itemId={id}
  * Must include {ItemId} at end of url

* **Update MenuItem** PUT: {localhost}/api/MenuItem
  * Must include in body

     | Key         | Value              |
     |-------------|--------------------|
     | ItemId      | id/int             |
     | ItemName    | name/string        |
     | Description | description/string |
     | Price       | price/double       |

* **Delete MenuItem** DELETE: {localhost}/api/MenuItem/{id}
  * Must include {ItemId} at end of url

### Test Order

*To completely test the Order CRUD in Postman you will need to validate the "Body" of each method.  When making changes to the Order object you will need to specify the ID(s) needed before getting, updating, or deleting any existing Order object. When creating an Order object, a unique ID will be generated within the entity framework.*

* **Register A User**  POST https://44382/api/account/register 

* **Get Bearer Token**  GET https://44382/token

* * **Create Order** POST https://44382/api/Order
  * Must include in body

      | Key         | Value          |
      |-------------|----------------|
      | ShopId      | id/int         |
      | CustomerId  | id/int         |
      | TotalPrice  | decimal number |
      
* **Get All Orders** GET https://44382/api/Order

* * **Get All Orders For ONE Shop** GET https://44382/api/Order?shopId={shopId}
  *  * Replace {shopId} with the id of the shop you would like to view
  
* **Get Order by OrderId** GET https://44382/api/Order/{id}
 * * Replace {id} with the id of the order you would like to view

* **Update Order** PUT https://44382/api/Order/{id}
  * Must include in body
  * Replace {id} with the id of the order you want to update

      | Key         | Value          |
      |-------------|----------------|
      | OrderId     | id/int         |
      | ShopId      | id/int         |
      | CustomerId  | id/int         |
      | TotalPrice  | decimal number |

* **Delete Order** DELETE https://44382/api/Order/{id]
  * Replace {id} with the id of the order you want to delete

### Test OrderItem

*To completely test the Order CRUD in Postman you will need to validate the "Body" of each method.  When making changes to the Order object you will need to specify the ID(s) needed before getting, updating, or deleting any existing Order object. When creating an Order object, a unique ID will be generated within the entity framework.*

* **Register A User**  POST https://44382/api/account/register 

* **Get Bearer Token**  GET https://44382/token

* * **Create OrderItem** POST https://44382/api/OrderItem
  * Must include in body

      | Key      | Value       |
      |----------|-------------|
      | ItemId   |   id/int    |
      | OrderId  |   id/int    |
      | Quantity |    int      |
      
* **Get OrderItem by OrderId** GET https://44382/api/OrderItem/{id}
* * * Replace {id} with the id of the order you would like to view

* **Update OrderItem** PUT https://44382/api/OrderItem/{id}
  * Must include in body
  * Replace {id} with the id of the orderItem you want to update

      | Key         | Value          |
      |-------------|----------------|
      |     Id      |    id/int      |
      |   ItemId    |    id/int      |
      |   OrderId   |    id/int      |
      |  Quantity   |     int        |

* **Delete OrderItem** DELETE https://44382/api/OrderItem?orderId={orderId}&itemId={itemId}
  * Replace {orderId} with the id of the order you want to delete the item from and itemId
    with the id of the item you want to delete

### Group Members
* Cassandra Goodwin
* Jamie Hill
 * Joshua Erkman
 * Ric Wallace


### Resources
* https://guides.github.com/pdfs/markdown-cheatsheet-online.pdf
* https://video.search.yahoo.com/search/video;_ylt=AwrJ7Jryk0Ngj0MAizdXNyoA;_ylu=Y29sbwNiZjEEcG9zAzEEdnRpZAMEc2VjA3BpdnM-?p=how+to+create+a+read+me+in+visual+studio&fr2=piv-web&fr=mcafee#id=1&vid=3535e83b1bccb94a403f8ebd8c32ad01&action=view
* https://www.tablesgenerator.com/markdown_tables
