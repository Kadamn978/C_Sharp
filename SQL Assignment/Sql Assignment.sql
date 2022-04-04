--Assignments (31-mar-22)

-- 01. Write a statement that will select the City column from the Customers table
		select City from Customers;

-- 02. Select all the different values from the Country column in the Customers table.
		select Distinct country from Customers;

-- 03. Select all records where the City column has the value "London"
		select * from Customers where City = 'London';

-- 04. Use the NOT keyword to select all records where City is NOT "Berlin"
		select * from Customers where Not City = 'Berlin';

-- 05. Select all records where the CustomerID column has the value 23.
		select * from Customers where CustomerID = 23;

-- 06. Select all records where the City column has the value 'Berlin' and the PostalCode column has the value 121110.
		select * from Customers where Not City = 'Berlin' AND PostalCode = 121110;

--07. Select all records where the City column has the value 'Berlin' or 'London'.
		SELECT * FROM Customers WHERE  City = 'Berlin' OR City='London';

-- 08. Select all records from the Customers table, sort the result alphabetically by the column City.
		SELECT * FROM Customers ORDER BY City;

-- 09. Select all records from the Customers table, sort the result reversed alphabetically by the column City.
		SELECT * FROM Customers ORDER BY City DESC;

-- 10. Select all records from the Customers table, sort the result alphabetically, first by the column Country, then, by the column City
		SELECT * FROM Customers ORDER BY Country, City;

-- 11. Select all records from the Customers where the PostalCode column is empty.
		SELECT * FROM Customers WHERE  PostalCode is Null;

-- 12. Select all records from the Customers where the PostalCode column is NOT empty.
		SELECT * FROM Customers WHERE  PostalCode is not Null;

-- 13. Set the value of the City columns to 'Oslo', but only the ones where the Country column has the value "Norway".
		UPDATE Customers set City = 'Oslo' WHERE Country = 'Norway';

-- 14. Delete all the records from the Customers table where the Country value is 'Norway'.
		DELETE FROM Customers WHERE Country = 'Norway';

-- 15. Use the MIN function to select the record with the smallest value of the Price column.
		SELECT MIN(Price) as MinPrice FROM Products;

-- 16. Use an SQL function to select the record with the highest value of the Price column.
		SELECT MAX(Price) as MaxPrice FROM Products;

-- 17. Use the correct function to return the number of records that have the Price value set to 20
		SELECT COUNT(*)FROM Products WHERE Price = 20;

-- 18. Use an SQL function to calculate the average price of all products.
		SELECT AVG(Price) as AvgPrice FROM Products;

-- 19. Use an SQL function to calculate the sum of all the Price column values in the Products table
		SELECT SUM(Price) as SumPrice FROM Products;

-- 20. Select all records where the value of the City column starts with the letter "a".
		SELECT * FROM Customers WHERE City LIKE 'a%';

-- 21. Select all records where the value of the City column ends with the letter "a".
		SELECT * FROM Customers WHERE City LIKE '%a';

-- 22. Select all records where the value of the City column contains the letter "a".
		SELECT * FROM Customers WHERE City LIKE '%a%';

-- 23. Select all records where the value of the City column starts with letter "a" and ends with the letter "b".
		SELECT * FROM Customers WHERE City LIKE 'a%b' ;

-- 24. Select all records where the value of the City column does NOT start with the letter "a".
		SELECT * FROM Customers WHERE City NOT LIKE 'a%';

-- 25. Select all records where the second letter of the City is an "a".
		SELECT * FROM Customers WHERE City LIKE '_a%';

-- 26. Select all records where the first letter of the City is an "a" or a "c" or an "s".
		SELECT * FROM Customers WHERE City LIKE '[acs]%';

-- 27. Select all records where the first letter of the City starts with anything from an "a" to an "f".
		SELECT * FROM Customers WHERE City LIKE '[a-f]%';

-- 28. Select all records where the first letter of the City is NOT an "a" or a "c" or an "f".
		SELECT * FROM Customers WHERE City LIKE '[!acf]%';

-- 29. Use the IN operator to select all the records where the Country is either "Norway" or "France".
		SELECT * FROM Customers WHERE Country IN ('Norway', 'France');

-- 30. Use the IN operator to select all the records where Country is NOT "Norway" and NOT "France".
		SELECT * FROM Customers WHERE Country NOT IN ('Norway', 'France');

-- 31. Use the BETWEEN operator to select all the records where the value of the Price column is between 10 and 20
		SELECT * FROM Products WHERE Price BETWEEN 10 AND 20;

-- 32. Use the BETWEEN operator to select all the records where the value of the Price column is NOT between 10 and 20.
		SELECT * FROM Products WHERE Price NOT BETWEEN 10 AND 20;

-- 33. Use the BETWEEN operator to select all the records where the value of the ProductName column is alphabetically between 'Geitost' and 'Pavlova'.
		SELECT * FROM Products WHERE Name  BETWEEN 'Geitost' AND 'Pavlova';

-- 34. When displaying the Customers table, make an ALIAS of the PostalCode column, the column should be called Pno instead.
		SELECT Name, Address, PostalCode AS Pno FROM Customers;

-- 35. When displaying the Customers table, refer to the table as Consumers instead of Customers.
		SELECT * FROM Customers AS Consumers;

-- 36. List the number of customers in each country.
		SELECT COUNT(CustomerID),Country FROM Customers
		GROUP BY Country;

-- 37. List the number of customers in each country, ordered by the country with the most customers first.
		SELECT COUNT(CustomerID) as Count,Country FROM Customers
		GROUP BY Country 
		ORDER BY COUNT(CustomerID) DESC;

-- 38. Write the correct SQL statement to create a new database called testDB.
		CREATE DATABASE testDB;

-- 39. Write the correct SQL statement to delete a database named testDB
		DROP DATABASE testDB;

-- 40. Add a column of type DATE called Birthday in Persons table
		ALTER TABLE Persons ADD Birthday DATE;

-- 41. Delete the column Birthday from the Persons table
		ALTER TABLE Persons DROP COLUMN Birthday;

