# KaleMeCrazy

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


### Group Members
* Cassandra Goodwin
* Jamie Hill
 * Joshua Erkman
 * Ric Wallace


### Resources
* https://guides.github.com/pdfs/markdown-cheatsheet-online.pdf
* https://video.search.yahoo.com/search/video;_ylt=AwrJ7Jryk0Ngj0MAizdXNyoA;_ylu=Y29sbwNiZjEEcG9zAzEEdnRpZAMEc2VjA3BpdnM-?p=how+to+create+a+read+me+in+visual+studio&fr2=piv-web&fr=mcafee#id=1&vid=3535e83b1bccb94a403f8ebd8c32ad01&action=view
* https://www.tablesgenerator.com/markdown_tables
