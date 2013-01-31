Desk.com C# SDK
===============

	Author:		Daniel Saidi [daniel.saidi@gmail.com]

The Desk.com C# SDK is a work in progress (really, nothing more). The
solution contains classes that helps you connect to and work with the
desk.com API.

If you need an SDK that supports everything that the desk.com API has
to offer, this is not for you (at least not yet). The SDK can be used
for all GET services, but only has strongly-typed components for some
of them. Also, none of the POST, PUT or DELETE services are supported.

However, since the core logic is very general, extending the SDK with
what you miss should be a breeze. Just have a look at the things that
already exists, and follow the same patten.


Web resources
-------------

You can find more information about the SDK at the following places:

	Project site:	http://github.com/danielsaidi/desk-csharp-sdk
	Downloads:		http://github.com/danielsaidi/desk-csharp-sdk/tags
	Issues:			http://github.com/danielsaidi/desk-csharp-sdk/issues
	NuGet package:	coming soon... (will be on http://nuget.org/packages/desk-csharp-sdk)

Do not hesitate to contact me if you have any questions. To report an
issue or a bug, use the GitHub issue page or send me an e-mail.

Contributions to the library are more than welcome. Just send me pull
requests via GitHub or attach your code in an e-mail.


Getting started
---------------

To get started using the Desk.com C# SDK, either grab the source code
from the GitHub project page, grab a public release from the download
section or add a reference to the library directly from Visual Studio,
using NuGet (COMING SOON).

Once you have a reference in place, you can create a DeskApi instance
using the base url to your desk.com app's API, the key and the secret
of your desk.com app, as well as a token and token secret.

	var api = new DeskApi("url", "key", "secret", "token", "token secret");

With a DeskApi instance in place, you can start calling the API. This
approach is very flexible, but you will have to know the service urls
as well as which parameters each service supports.

If you do not want to care about service urls, request parameters and
other API details, use the DeskApiMapper class. To create an instance,
you must provide it with an already setup api instance.

	var apiMapper = new DeskApiMapper(api);

The DeskApiMapper class adds a strongly typed layer on top of the SDK.
It has dedicated methods for each service (the ones it supports), and
uses strongly typed request parameters, which makes it really easy to
define which ones to send.

The DeskApiMapper is really convenient, but until all API methods are
mapped, you will need the DeskApi class as well.


Mapped API resources
--------------------

Content resources

	topics 



Unmapped API resources (todo)
-----------------------------

Case resources

	cases 
	cases/show 
	case/update 

Customer resources

	customers 
	customers/show 
	customers/create 
	customers/update 
	customers/emails/create 
	customers/emails/update 
	customers/phones/create 
	customers/phones/update 

Interaction resources

	interactions 
	interaction/create 

User resources

	groups 
	groups/show 
	users 
	users/show 

Content resources

	topics/show 
	topics/create 
	topics/update 
	topics/destroy 
	topics/articles 
	topics/articles/create 
	articles/show 
	articles/update 
	articles/destroy 

Macro resources

	macros 
	macros/create 
	macros/show 
	macros/update 
	macros/destroy 
	macros/actions 
	macros/actions/show 
	macros/actions/update 


License
-------

The Desk.com C# SDK is released under the MIT License, which lets you
do much about anything you want with it. Read more here:

http://www.opensource.org/licenses/mit-license.php

The license basically means that, if you use this SDK and also happen
to like it, please spread the word. Furthermore, do not steawl credit
for other's work. If you extract anything out of the project, let the
author information remain in the source code.

