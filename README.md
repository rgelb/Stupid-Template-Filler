Stupid-Template-Filler
======================

Just like the name suggest, this is a quick & dirty template filler.  

You provide the query like this:
```sh
  SELECT name, Value, Description FROM dbo.Config
```
and a Template like this:
```sh
  IF NOT EXISTS ( SELECT 1 FROM dbo.Config WHERE Name = '{0}') 
  BEGIN
      INSERT  dbo.Config (Name, Value, Description)
      VALUES  (N'{0}', N'{1}', N'{2}')
  END
```
  
The application then produces an output of the template for each row returned from the query.  {0}, {1}, {n} correspond to the columns returned.  Sample output:
```sh  
  IF NOT EXISTS ( SELECT 1 FROM dbo.Config WHERE Name = 'NewBusinessReloadTime') 
  BEGIN
      INSERT  dbo.Config (Name, Value, Description)
      VALUES  (N'NewBusinessReloadTime', N'06:00:00', N'The Time New Business Service Reloads all data into memory')
  END
  
  IF NOT EXISTS ( SELECT 1 FROM dbo.Config WHERE Name = 'NewBusinessCCAComparisonDate') 
  BEGIN
      INSERT  dbo.Config (Name, Value, Description)
      VALUES  (N'NewBusinessCCAComparisonDate', N'1900-01-01 00:00:00.000', N'NewBusiness CCA Comparison Date')
  END
```

