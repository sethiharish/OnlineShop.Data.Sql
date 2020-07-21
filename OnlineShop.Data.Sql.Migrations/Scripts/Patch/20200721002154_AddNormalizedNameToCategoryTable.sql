ALTER TABLE [Category] ADD [NormalizedName] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200721002154_AddNormalizedNameToCategoryTable', N'3.1.6');

GO

