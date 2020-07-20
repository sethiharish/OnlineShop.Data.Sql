INSERT INTO Banner (Name, Description, ImageUrl)
SELECT 'Carousel1' Name, 'We sell the best pies in the town!' Description, '/images/carousel1.jpg' ImageUrl
WHERE NOT EXISTS (SELECT 1 FROM Banner WHERE Name = 'Carousel1')

GO

INSERT INTO Banner (Name, Description, ImageUrl)
SELECT 'Carousel2' Name, 'We sell the best pies in the town!' Description, '/images/carousel2.jpg' ImageUrl
WHERE NOT EXISTS (SELECT 1 FROM Banner WHERE Name = 'Carousel2')

GO

INSERT INTO Banner (Name, Description, ImageUrl)
SELECT 'Carousel3' Name, 'We sell the best pies in the town!' Description, '/images/carousel3.jpg' ImageUrl
WHERE NOT EXISTS (SELECT 1 FROM Banner WHERE Name = 'Carousel3')

GO

INSERT INTO Category (Name, Description)
SELECT 'Fruit pies' Name, 'Fruit pies' Description
WHERE NOT EXISTS (SELECT 1 FROM Category WHERE Name = 'Fruit pies')

GO

INSERT INTO Category (Name, Description)
SELECT 'Cheese cakes' Name, 'Cheese cakes' Description
WHERE NOT EXISTS (SELECT 1 FROM Category WHERE Name = 'Cheese cakes')

GO

INSERT INTO Category (Name, Description)
SELECT 'Seasonal pies' Name, 'Seasonal pies' Description
WHERE NOT EXISTS (SELECT 1 FROM Category WHERE Name = 'Seasonal pies')

GO

INSERT INTO Pie (Name, Price, ShortDescription, LongDescription, InStock, IsPieOfTheWeek, ImageUrl, ThumbnailImageUrl, CategoryId)
SELECT 'Apple Pie' Name, 12.95 Price, 'Our famous apple pies!' ShortDescription, 'Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.' LongDescription, 1 InStock, 1 IsPieOfTheWeek, '/images/pies/applepie.jpg' ImageUrl, '/images/pies/thumbnails/applepiesmall.jpg' ThumbnailImageUrl, (Select Id From Category Where Name = 'Fruit pies') CategoryId
WHERE NOT EXISTS (SELECT 1 FROM Pie WHERE Name = 'Apple Pie')

GO

INSERT INTO Pie (Name, Price, ShortDescription, LongDescription, InStock, IsPieOfTheWeek, ImageUrl, ThumbnailImageUrl, CategoryId)
SELECT 'Blueberry Cheese Cake' Name, 18.95 Price, 'You''ll love it!' ShortDescription, 'Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.' LongDescription, 1 InStock, 0 IsPieOfTheWeek, '/images/pies/blueberrycheesecake.jpg' ImageUrl, '/images/pies/thumbnails/blueberrycheesecakesmall.jpg' ThumbnailImageUrl, (Select Id From Category Where Name = 'Cheese cakes') CategoryId
WHERE NOT EXISTS (SELECT 1 FROM Pie WHERE Name = 'Blueberry Cheese Cake')

GO

INSERT INTO Pie (Name, Price, ShortDescription, LongDescription, InStock, IsPieOfTheWeek, ImageUrl, ThumbnailImageUrl, CategoryId)
SELECT 'Cheese Cake' Name, 18.95 Price, 'Plain cheese cake. Plain pleasure.' ShortDescription, 'Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.' LongDescription, 1 InStock, 0 IsPieOfTheWeek, '/images/pies/cheesecake.jpg' ImageUrl, '/images/pies/thumbnails/cheesecakesmall.jpg' ThumbnailImageUrl, (Select Id From Category Where Name = 'Cheese cakes') CategoryId
WHERE NOT EXISTS (SELECT 1 FROM Pie WHERE Name = 'Cheese Cake')

GO

INSERT INTO Pie (Name, Price, ShortDescription, LongDescription, InStock, IsPieOfTheWeek, ImageUrl, ThumbnailImageUrl, CategoryId)
SELECT 'Cherry Pie' Name, 15.95 Price, 'A summer classic!' ShortDescription, 'Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.' LongDescription, 1 InStock, 0 IsPieOfTheWeek, '/images/pies/cherrypie.jpg' ImageUrl, '/images/pies/thumbnails/cherrypiesmall.jpg' ThumbnailImageUrl, (Select Id From Category Where Name = 'Fruit pies') CategoryId
WHERE NOT EXISTS (SELECT 1 FROM Pie WHERE Name = 'Cherry Pie')

GO

INSERT INTO Pie (Name, Price, ShortDescription, LongDescription, InStock, IsPieOfTheWeek, ImageUrl, ThumbnailImageUrl, CategoryId)
SELECT 'Christmas Apple Pie' Name, 13.95 Price, 'Happy holidays with this pie!' ShortDescription, 'Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.' LongDescription, 1 InStock, 0 IsPieOfTheWeek, '/images/pies/christmasapplepie.jpg' ImageUrl, '/images/pies/thumbnails/christmasapplepiesmall.jpg' ThumbnailImageUrl, (Select Id From Category Where Name = 'Seasonal pies') CategoryId
WHERE NOT EXISTS (SELECT 1 FROM Pie WHERE Name = 'Christmas Apple Pie')

GO

INSERT INTO Pie (Name, Price, ShortDescription, LongDescription, InStock, IsPieOfTheWeek, ImageUrl, ThumbnailImageUrl, CategoryId)
SELECT 'Cranberry Pie' Name, 17.95 Price, 'A Christmas favorite' ShortDescription, 'Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.' LongDescription, 1 InStock, 0 IsPieOfTheWeek, '/images/pies/cranberrypie.jpg' ImageUrl, '/images/pies/thumbnails/cranberrypiesmall.jpg' ThumbnailImageUrl, (Select Id From Category Where Name = 'Seasonal pies') CategoryId
WHERE NOT EXISTS (SELECT 1 FROM Pie WHERE Name = 'Cranberry Pie')

GO

INSERT INTO Pie (Name, Price, ShortDescription, LongDescription, InStock, IsPieOfTheWeek, ImageUrl, ThumbnailImageUrl, CategoryId)
SELECT 'Peach Pie' Name, 15.95 Price, 'Sweet as peach' ShortDescription, 'Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.' LongDescription, 0 InStock, 0 IsPieOfTheWeek, '/images/pies/peachpie.jpg' ImageUrl, '/images/pies/thumbnails/peachpiesmall.jpg' ThumbnailImageUrl, (Select Id From Category Where Name = 'Fruit pies') CategoryId
WHERE NOT EXISTS (SELECT 1 FROM Pie WHERE Name = 'Peach Pie')

GO

INSERT INTO Pie (Name, Price, ShortDescription, LongDescription, InStock, IsPieOfTheWeek, ImageUrl, ThumbnailImageUrl, CategoryId)
SELECT 'Pumpkin Pie' Name, 12.95 Price, 'Our Halloween favorite' ShortDescription, 'Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.' LongDescription, 1 InStock, 1 IsPieOfTheWeek, '/images/pies/pumpkinpie.jpg' ImageUrl, '/images/pies/thumbnails/pumpkinpiesmall.jpg' ThumbnailImageUrl, (Select Id From Category Where Name = 'Seasonal pies') CategoryId
WHERE NOT EXISTS (SELECT 1 FROM Pie WHERE Name = 'Pumpkin Pie')

GO

INSERT INTO Pie (Name, Price, ShortDescription, LongDescription, InStock, IsPieOfTheWeek, ImageUrl, ThumbnailImageUrl, CategoryId)
SELECT 'Rhubarb Pie' Name, 15.95 Price, 'My God, so sweet!' ShortDescription, 'Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.' LongDescription, 1 InStock, 1 IsPieOfTheWeek, '/images/pies/rhubarbpie.jpg' ImageUrl, '/images/pies/thumbnails/rhubarbpiesmall.jpg' ThumbnailImageUrl, (Select Id From Category Where Name = 'Fruit pies') CategoryId
WHERE NOT EXISTS (SELECT 1 FROM Pie WHERE Name = 'Rhubarb Pie')

GO

INSERT INTO Pie (Name, Price, ShortDescription, LongDescription, InStock, IsPieOfTheWeek, ImageUrl, ThumbnailImageUrl, CategoryId)
SELECT 'Strawberry Pie' Name, 15.95 Price, 'Our delicious strawberry pie!' ShortDescription, 'Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.' LongDescription, 1 InStock, 0 IsPieOfTheWeek, '/images/pies/strawberrypie.jpg' ImageUrl, '/images/pies/thumbnails/strawberrypiesmall.jpg' ThumbnailImageUrl, (Select Id From Category Where Name = 'Fruit pies') CategoryId
WHERE NOT EXISTS (SELECT 1 FROM Pie WHERE Name = 'Strawberry Pie')

GO

INSERT INTO Pie (Name, Price, ShortDescription, LongDescription, InStock, IsPieOfTheWeek, ImageUrl, ThumbnailImageUrl, CategoryId)
SELECT 'Strawberry Cheese Cake' Name, 18.95 Price, 'You''ll love it!' ShortDescription, 'Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.' LongDescription, 0 InStock, 0 IsPieOfTheWeek, '/images/pies/strawberrycheesecake.jpg' ImageUrl, '/images/pies/thumbnails/strawberrycheesecakesmall.jpg' ThumbnailImageUrl, (Select Id From Category Where Name = 'Cheese cakes') CategoryId
WHERE NOT EXISTS (SELECT 1 FROM Pie WHERE Name = 'Strawberry Cheese Cake')

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200719141749_SeedDatabase', N'3.1.6');

GO

