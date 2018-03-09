-- Examples for queries that exercise different SQL objects implemented by this assembly

-----------------------------------------------------------------------------------------
-- Stored procedure
-----------------------------------------------------------------------------------------
-- exec StoredProcedureName


-----------------------------------------------------------------------------------------
-- User defined function
-----------------------------------------------------------------------------------------
-- select dbo.FunctionName()


-----------------------------------------------------------------------------------------
-- User defined type
-----------------------------------------------------------------------------------------
 DECLARE  @test_table TABLE(col1 varchar(50))
 

INSERT INTO @test_table VALUES ('Instantiation String 1')
INSERT INTO @test_table VALUES ('Instantiation String 2')
INSERT INTO @test_table VALUES ('Instantiation String 3')

--select col1::method1() from test_table



-----------------------------------------------------------------------------------------
-- User defined type
-----------------------------------------------------------------------------------------
 select dbo.PICKRANDOM(col1) from @test_table


--select 'To run your project, please edit the Test.sql file in your project. This file is located in the Test Scripts folder in the Solution Explorer.'
