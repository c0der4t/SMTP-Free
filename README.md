# SMTP-Free

### ⚠️ This repo is in initial development and is not ready for consumer use yet.

![enter image description here](https://img.shields.io/badge/license-MIT-lightgrey)
Read more regarding this license at the end of this ReadMe

#### Summary
SMTP Free is a small lightweight utility that allows the sending of customized HTML / Plain text emails from scripts or other software using simple CLI commands or even by dropping an .html or .txt file in its queue

#### Build layout
The application has three components that work together to provide an easy-going user experience:

- Setup application: Allows for the setup of the SMTP account used to send emails as well as additional settings
- CLI: The CLI allows other software or scripts to call it with sufficient parameters which will be used to create a .html or .txt file, populated with custom variables etc. It will then drop the files in the service queue
- Service / Worker application: This is a service that runs in the background. As the queue fills it empties it by taking each file in the queue and sending it with the SMTP settings supplied.

#### Roadmap
✅ Project start
|
🟠 Deliver the full system in beta
|
🟠 Refactor and cleanup existing code
|
🟠 Address major bugs if reported
|
🟠 Add custom variable replacement
|
🟠 Add basic template creator

### Pull it ↘️
If you see the potential of this utility, and would like to help, please feel free to jump in and send through the pull requests.

#### License - Expanded:
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following condition:
- The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.