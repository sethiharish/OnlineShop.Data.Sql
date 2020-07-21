Update Category SET NormalizedName = UPPER(Name)

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200721002257_SeedNormalizedNameColumnInCategoryTable', N'3.1.6');

GO

