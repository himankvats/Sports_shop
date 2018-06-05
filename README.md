# Sports_shop
Main functions software project: 1. The employee of Highsports will be allowed to check the item availability of the item at the store on a day. This feature will be developed by making the web client interact with the local database of the store. 2. If the product is not available at the store the employee is provided the feature to check if the item is available at the externally located storage space of the store. This feature will be enabled by making the web client interact with the web server and access the web services using access method.  3. The search feature will be accessible by using the product ID or the product name.

Databases Description:
•	This project has web application to search in local database and inventory database.
•	web service, will be consumed in web application to search inventory.
•	The local database which is directly accessed by web application is .mdb file and inventory system is hosted in Azure cloud database.

Webpage Functionality:
•	The search can be done by product ID or product name, which can be selected in dropdown list located on page.
•	To search the local database, click on “At Store” button.
•	To search the local database, click on “At Warehouse” button. 

Search Functionality: 
Search feature is designed in such a way that the product results can be obtained by to methods:
1.	By searching using product ID
•	The patterned enter is matched from starting of the string to fetch result output. 
2.	By searching using product name
•	The pattern provided will be matched in product name that have occurrence of that pattern anywhere in the name.

System requirements:
Microsoft Visual Studio Express edition 2012 and above.
