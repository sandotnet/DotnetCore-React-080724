

-- **************************************************
-- SCRIPTS
-- **************************************************

-- Write commands and save it either with .sql file extension 
-- or any other file extension. This is known as a "Script".

-- **************************************************
-- BATCHES
-- **************************************************

-- A single or set of T-SQL commands sent to SQL Server engine
-- for processing is known as a "Batch".

-- A batch is denoted by using "GO" keyword.
-- Demo with 3 SELECT statements and GO keyword.

SELECT *
FROM Person.Contact

SELECT * 
FROM HumanResources.Employee

SELECT * 
FROM HumanResources.Department
WHER DepartmentID = 1
GO

-- **************************************************
-- STATEMENT TERMINATOR (;)
-- **************************************************

-- It's a statement terminator and optional to write.
-- People worked in older programming languages use this symbol to denote
-- the end of a statement.

-- Example 1:

   SELECT * 
   FROM Person.Contact;
   GO

-- **************************************************
-- USE STATEMENT
-- **************************************************

-- "USE" statement is used to select the database against that T-SQL queries
-- in the current window will get executed.

   USE Northwind
   GO
   
   USE AdventureWorks
   GO

-- **************************************************
-- DECLARE STATEMENT
-- **************************************************

-- "DECLARE" statement is used in order to create a variable in T-SQL commands.

-- Example 1: Declaring multiple variables using multiple DECLARE statements

   DECLARE @FirstName VARCHAR(50)
   DECLARE @PostalCode BIGINT
   
-- Example 2: Declaring multiple variables using single DECLARE statements

   DECLARE @AddressLine1 VARCHAR(50), @AddressLine2 VARCHAR(50)
   DECLARE @CountryName VARCHAR(50), @StateID BIGINT   	   


-- **************************************************
-- SET STATEMENT
-- **************************************************

-- "SET" statement is used assign value to a variable

-- Example 1: Declaring and assigning a value in a single line

   DECLARE @EmployeeName VARCHAR(50) = 'Ramesh K.'
   
-- Example 2: Declaring and assigning a value in separate line

   DECLARE @ManagerName VARCHAR(50)   
   SET @ManagerName = 'Ramesh K.'
   

-- **************************************************
-- "BEGIN...END" BLOCK STATEMENT
-- **************************************************
	
-- "BEGIN...END" block statement makes a block of statement. If more than one 
-- statements are to be executed, then we need to put them inside "Begin...End"
-- block. However, it doesn't define any scope for variable declaration as it 
-- happens in other programming languages like C# or VB.NET.
	
-- Example 1:

   DECLARE @FirstNo INT = 10
   DECLARE @SecondNo INT = 20
	
   IF(@FirstNo = @SecondNo)
		BEGIN -- Using becuase two statements need to be executed			
			DECLARE @Msg VARCHAR(50)
			SET @Msg = 'Values matched!'	
		END			
   ELSE IF (@FirstNo = 10)
		-- Not using Begin...End as only single statement needs to be executed
		SET @Msg = 'Values not matched!' -- Variable declared in IF part is being used
		
   SELECT @Msg;
   
   
-- **************************************************
-- "PRINT()" STATEMENT
-- **************************************************

-- "Print()" function is used to print a string. Output is displayed into Messages tab.

-- Example 1:
   PRINT('This is demo string message.')
   
-- Example 2: Printing value of a variable of BIGINT data type.   
   DECLARE @Age BIGINT = 50
   --PRINT('Age is: ' + @Age) -- Raises an error
   
   PRINT('Age is: ' + CAST(@Age AS VARCHAR))
   
-- **************************************************
-- "IF...ELSE IF...ELSE" CONTROL FLOW STATEMENT
-- **************************************************

-- Example 1:

   DECLARE @Num1 INT = 100
   DECLARE @Num2 INT = 200
	
   IF(@Num1 = @Num2)
		BEGIN -- Using becuase two statements need to be executed			
			DECLARE @Message VARCHAR(50)
			SET @Message = 'Values matched!'	
		END			
   ELSE IF (@Num1 = 100)
		-- Not using Begin...End as only single statement needs to be executed
		SET @Message = 'Values not matched!' -- Variable declared in IF part is being used
   ELSE
		SET @Message = 'Nothing matched!'		
		
   PRINT @Message;


-- **************************************************
-- "WHILE..." LOOP STATEMENT
-- **************************************************
   
-- Example 1:

   DECLARE @Counter INT = 1
   DECLARE @TotalLoops INT = 5
	
   WHILE(@Counter <= @TotalLoops)
		BEGIN 
			PRINT ('Loop No.: ' + CAST(@Counter AS VARCHAR)) 
			SET @Counter = @Counter + 1
		END			

-- **************************************************
-- BREAK with WHILE LOOP
-- **************************************************   

-- Example 1:

   DECLARE @CounterFlag INT
   SET @CounterFlag = 1
   
   WHILE (@CounterFlag <=6)
		BEGIN
			PRINT ('Loop No.: ' + CAST(@CounterFlag AS VARCHAR))
			SET @CounterFlag = @CounterFlag + 1
			IF @CounterFlag = 3
				BREAK;
		END;
   GO

   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
-- **************************************************
-- GLOBAL VARIABLES
-- **************************************************   

-- @@ROWCOUNT
-- @@IDENTITY
-- @@ERROR



-- **************************************************
-- WAITFOR, DELAY and TIME STATEMENTS
-- **************************************************
