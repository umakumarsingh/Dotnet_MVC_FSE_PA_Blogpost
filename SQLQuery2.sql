USE [Blog]
GO

/****** Object:  Table [dbo].[Post]    Script Date: 07-09-2020 02:10:46 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Post](
	[PostId] [int] NOT NULL,
	[Title] [varchar](100) NOT NULL,
	[Abstract] [varchar](200) NOT NULL,
	[Description] [varchar](500) NOT NULL,
	[PostedDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PostId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[Comment](
	[CommId] [int] NOT NULL,
	[CommentMsg] [varchar](200) NULL,
	[CommentedDate] [datetime] NULL,
	[PostId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CommId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Comment]  WITH CHECK ADD FOREIGN KEY([PostId])
REFERENCES [dbo].[Post] ([PostId])
GO
insert into Post(PostId,Title, Abstract, Description, PostedDate) values(1,'Blog Post Test', 'Blog', 'Check Blog Post App', 2020-06-24)
go
