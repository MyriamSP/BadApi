# RestBadApi
Takehome test for IQVIA
## Problem
### A Bad REST API

A Client needs us to pull 2 years of ultra-cool curated tweets they have collected and stored themselves.
We need to make sure that we get all tweets tweeted in 2016 and 2017.

##UI##
#StartDate: Selection of a start date stamp, Min Value: 1/1/2016, Max Value: 12/30/2017
#EndDate: Selection of an end date stamp, Min Value: 1/2/2016, Max Value: 12/31/2017

#Example:

StartDate: 1/1/2016
EndDate: 1/2/2016 
Shows: Records of day: 1/1/2016  

##Total Unique Tweets: Displays the tweets which time stamp was selected in the date range selection. (datagridview)

##Message: Not longer used. Use it for debugging purposes.

##Tweet Summary:
  #Total Unique Tweets: Number of tweets displayed in the Total Unique Tweets datagridview.
  #Duplicated Tweets: Number of duplicated tweets found.


###NOTE###
The project uses Json.NET (JSON framework for .NET) for handling the JSON data. The package was added to the Project Solution
https://www.newtonsoft.com/json/help/html/Introduction.htm

How to install and use a package in Visual Studio:
https://docs.microsoft.com/en-us/nuget/quickstart/install-and-use-a-package-in-visual-studio
