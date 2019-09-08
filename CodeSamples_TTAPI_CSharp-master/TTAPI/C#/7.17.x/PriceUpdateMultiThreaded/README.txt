﻿README.txt
PriceUpdateMultiThreaded (C#)
===============================================================================

Overview
-------------------------------------------------------------------------------

This example demonstrates using the TT API to retrieve market data from 
multiple instruments.  Each PriceSubscription will be on it's own thread.


Instructions
-------------------------------------------------------------------------------

1. Drag and drop up to four Instruments from the Market Grid in X_TRADER.
2. The instrument data will populate in the text boxes.


TT API Objects
-------------------------------------------------------------------------------

PriceSubscription


Revisions
-------------------------------------------------------------------------------

Version:		1.0.0
Date Created:	05/15/2012
Notes:			None

Version:		1.1.0
Date Created:	01/18/2013
Notes:			Updated for GitHub.

Version:		1.1.1
Date Created:	05/23/2013
Notes:			Fixed issue with shutdown.  Move the PriceSubscription within
				the InstrumentModel class.

Version:		7.17.0
Date Created:	10/02/2013
Notes:			Updated for TT API 7.17.  Changed initialization
				and shutdown code.