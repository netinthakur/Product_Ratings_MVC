INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'338470e3-bba4-4404-9544-3308492cd2e0', N'admin@ratings.com', N'ADMIN@RATINGS.COM', N'admin@ratings.com', N'ADMIN@RATINGS.COM', 1, N'AQAAAAEAACcQAAAAEItHTCwJRWO1YlgwTP5Y7Vh1rlY6rd5Ev4y8INdK9ZLwk9LfyZvolEDY0IJ8nUVbYw==', N'MPIHBFUX2H7VZSTJKYXPPKRQYAJOOHHP', N'6cdd2e96-2bca-48f4-b3f0-d272fc55fd6f', NULL, 0, 0, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[Customer] ON
INSERT INTO [dbo].[Customer] ([Id], [Name], [Email]) VALUES (1, N'Mac Davis', N'mac@gmail.com')
INSERT INTO [dbo].[Customer] ([Id], [Name], [Email]) VALUES (2, N'Samson Wilkinson', N'sam@gmail.com')
INSERT INTO [dbo].[Customer] ([Id], [Name], [Email]) VALUES (3, N'John Walker', N'john@gmail.com')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Product] ON
INSERT INTO [dbo].[Product] ([Id], [Name], [Price]) VALUES (1, N'iPhone 8 ', CAST(900.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Product] ([Id], [Name], [Price]) VALUES (2, N'Play Station 4 ', CAST(600.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Product] ([Id], [Name], [Price]) VALUES (3, N'HP Elite Book ', CAST(700.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Product] OFF
SET IDENTITY_INSERT [dbo].[Rating] ON
INSERT INTO [dbo].[Rating] ([Id], [CustomerId], [ProductId], [RatingValue], [Comment]) VALUES (1, 2, 1, 5, N'Great Product!')
INSERT INTO [dbo].[Rating] ([Id], [CustomerId], [ProductId], [RatingValue], [Comment]) VALUES (2, 1, 2, 5, N'Great value for price!')
INSERT INTO [dbo].[Rating] ([Id], [CustomerId], [ProductId], [RatingValue], [Comment]) VALUES (3, 3, 3, 5, N'Excellent performance')
SET IDENTITY_INSERT [dbo].[Rating] OFF
