USE [MESThailandlocal]
GO
/****** Object:  StoredProcedure [dbo].[GetCountByWorkTimes]    Script Date: 05/19/2016 22:09:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 工作时间段
CREATE TABLE [dbo].[workTimes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[startTime] [varchar](10) NOT NULL DEFAULT(''),	-- 开始时间，如 07:30
	[endTime] [varchar](10) NOT NULL DEFAULT(''),	-- 结束时间，如 09:00
	[ENABLED] [char](1) NOT NULL DEFAULT('Y')		-- 是否启用此时间段
) 

insert into dbo.workTimes(startTime,endTime) values('07:30','08:30');
insert into dbo.workTimes(startTime,endTime) values('08:31','09:30');
insert into dbo.workTimes(startTime,endTime) values('09:31','10:30');
insert into dbo.workTimes(startTime,endTime) values('10:31','11:30');
insert into dbo.workTimes(startTime,endTime) values('11:31','12:30');
insert into dbo.workTimes(startTime,endTime) values('12:31','13:30');
insert into dbo.workTimes(startTime,endTime) values('13:31','14:30');
insert into dbo.workTimes(startTime,endTime) values('14:31','15:30');
insert into dbo.workTimes(startTime,endTime) values('15:31','16:30');
insert into dbo.workTimes(startTime,endTime) values('16:31','17:30');
insert into dbo.workTimes(startTime,endTime) values('17:31','18:30');
insert into dbo.workTimes(startTime,endTime) values('18:31','19:30');
insert into dbo.workTimes(startTime,endTime) values('19:31','20:30');

