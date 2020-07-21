Update Category SET NormalizedName = Name

GO

DELETE FROM [__EFMigrationsHistory]
WHERE [MigrationId] = N'20200721002257_SeedNormalizedNameColumnInCategoryTable';

GO

