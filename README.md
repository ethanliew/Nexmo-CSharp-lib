# About

A CSharp Library for [nexmo](http://nexmo.com/) SMS API

# Installation

## Via NuGet

Install log4net:

	Install-Package log4net
Install Common.Logging:

	Install-Package Common.Logging
Install Common.Logging.Log4Net:

	Install-Package Common.Logging.Log4Net
Install Newtonsoft.Json:

	Install-Package Newtonsoft.Json

# Example

###1) create a text/binary model
	var textModel = new TextRequestModel {Text = "HelloWorld!"};

###2) make a requestModel 
	
	var requestModel = RequestModelBuilder.Create("{USERNAME}", "{PASSWORD}", "{FROM}", "{TO}", textModel);

###3)  Sending SMS and Recieving response
	var nexmo = new Nexmo();
	
	var responseModel = nexmo.Send(requestModel, ResponseObjectType.Json);

# Authors

* siutin ([twitter.com/osiutino](http://twitter.com/osiutino))	

#License


The MIT License (MIT)
Copyright (c) 2011 siutin

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.	