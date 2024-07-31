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