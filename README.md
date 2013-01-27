CountAnything
=============
**[Project homepage](http://tapesoftware.net/content/countanything)** - **[Download link](http://lambda.tapesoftware.net/CountAnything.zip)**

![Main window](http://tapesoftware.net/sites/default/files/field/image/coa1.png)

This is a generic (Windows-only) counting application. It allows the user to have a counter. Which counts. It's that simple. It was designed for the [speedrunning community](http://speedrunslive.com). If you see [tape1](http://twitch.tv/tape1) streaming, say hi!  

Usage
-----
Start the CountAnything application and you will see the above window. You can move it around by clicking and dragging anywhere in the window. Right-Click to open the context menu, and click "Configure..." to open the configuration dialog (described in the next section).

To include the counter in a live stream, use a software capture in OBS / whatever it's called in XSplit. You can use a color key to make the counter transparent.

Configuration
-------------
The configuration dialog has three pages: *General*, *Display* and *Hotkeys*. All changes you make in this dialog are saved automatically and will be loaded the next time you start CountAnything.

### General
![General config](http://tapesoftware.net/sites/default/files/field/image/coa2.png)

* *Count to what*: Target value of the counter.

### Display
![Display config](http://tapesoftware.net/sites/default/files/field/image/coa3.png)

* *Not finished color:* Color of the counter when it has not reached the target value.
* *Finished color:* Color of the counter when it has reached the target value.
* *Background color:* Background color of the counter.
* *Font:* Font used in the counter.
* *Format:* Text format of the counter (i.e. the `{0}/{1}` resulted in the `18/60` in the screenshot above)

### Hotkeys
![Hotkeys config](http://tapesoftware.net/sites/default/files/field/image/coa4.png)

* *Double Tap Prevention:* If a hotkey is twice in the specified timeframe, it will only be registered the first time.

The hotkeys are self-explanatory. Click inside the boxes and press the desired key combination. Click on the "Clear" button to remove the hotkey.

Compiling the Source Code
-------------------------
*(ignore this section if you use the download link above)*

Open the solution in Visual Studio 2010 and press "F6". Or use MSBuild.

Something doesn't work
----------------------
If you have a problem with the application or want a feature to be added, feel free to create an issue by clicking on the "Issues" link above.

If you don't want to create a GitHub account, you can also send me an E-Mail. My first name is Raphael, and my E-mail address is `(my first name)@tapesoftware.net`.

Licence Agreement
-----------------
(BSD 3-Clause)

Copyright (c) 2013, tape software  
All rights reserved.

Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:

* Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
* Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
* Neither the name of tape software nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.


THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
