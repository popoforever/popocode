USE [MESThailandlocal]
GO
/****** Object:  StoredProcedure [dbo].[GetCountByWorkTimes]    Script Date: 05/19/2016 22:09:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Create date: <2016-05-19>
-- Description:	<按照日期及时间段设置统计下线条码数量>
-- =============================================
-- exec dbo.GetCountByWorkTimes '2016-05-18'
CREATE PROCEDURE [dbo].[GetCountByWorkTimes] ( @workDay VARCHAR(10) )
AS 
    BEGIN
        SET NOCOUNT ON;

        CREATE TABLE #workTimes
            (
              id INT IDENTITY(1, 1) ,
              startTime VARCHAR(10) ,
              endTime VARCHAR(10) ,
              traceQty INT DEFAULT ( 0 )
            )
    
        INSERT  INTO #workTimes ( startTime, endTime )
                SELECT  startTime, endTime
                FROM    dbo.workTimes
                WHERE   ENABLED = 'Y'
                ORDER BY id
    
        DECLARE @index INT 
        DECLARE @count INT
        DECLARE @startTime VARCHAR(10)
        DECLARE @endTime VARCHAR(10)
        DECLARE @traceQty INT
    
        SET @index = 1
    
        SELECT  @count = COUNT(1)
        FROM    #workTimes
    
        WHILE @index <= @count 
            BEGIN	
                SELECT  @startTime = startTime, @endTime = endTime
                FROM    #workTimes
                WHERE   id = @index
		
                SELECT  @traceQty = COUNT(1)
                FROM    dbo.record
                WHERE   CONVERT(VARCHAR(10), tracedatetime, 120) = @workDay
                        AND CONVERT(VARCHAR(5), tracedatetime, 108) >= @startTime
                        AND CONVERT(VARCHAR(5), tracedatetime, 108) <= @endTime
		
                UPDATE  #workTimes
                SET     traceQty = @traceQty
                WHERE   id = @index
		
                SET @index = @index + 1
            END
            
      SELECT * FROM #workTimes ORDER BY id
      
      DROP TABLE #workTimes
    END
