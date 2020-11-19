This project replicates a bug in Xamarin.Essentials which involves openning email on devices that current running iOS 9
### Description
Recently I migrated Xamarin.Forms from v3.6 to the latest stable v4.8. In the process, the old code that was used for opening email was Device.OpenUri("mailto:somemail@somedomain.com"). But this code, Device.OpenUri is deprecated as of Xamarin.Forms v4.8. So I replace it with Xamarin.Essentials' Email.ComposeAsync. The problem is that I still have to support devices running iOS 9, and I tried both Email.ComposeAsync as well as Launcher.OpenAsync but neither of them support iOS 9. Thus causing a bit of inconvenience here.
### Steps to Reproduce

1. Download/Clone the project.
2. Run the application on an iOS 9 device.
3. Tap on each sample email provided on the initial screen.

### Expected Behavior
Can open the email app
### Actual Behavior
Can not open the email app
### Basic Information

- IDE: Visual Studio for Mac 2019
- Platform Target Frameworks:
  - iOS: 14.4.1.3
- Affected Devices: iOS devices running iOS 9

### Workaround

The only workaround I found is switch back to Device.OpenUri and add suppress warning. But this is not pretty. Someone might be thinking "Oh, it's 2020 and nobody is using iOS 9 anymore". But the fact is there still users who hasn't update their iDevices and there are specific cases that I need to deploy to them.
