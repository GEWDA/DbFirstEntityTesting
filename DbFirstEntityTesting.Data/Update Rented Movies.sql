USE [Movies.mdf]
GO

/****** Object:  Index [PK_RentedMovies]    Script Date: 04/07/2017 02:06:17 PM ******/
ALTER TABLE [dbo].[RentedMovies] ADD  CONSTRAINT [PK_RentedMovies] PRIMARY KEY CLUSTERED 
(
	[RMID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO


