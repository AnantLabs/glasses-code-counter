; Glass Code Counter Setup Script

[Setup]
AppId={{EF61060D-6088-46AD-98A9-49F971F83CE6}
AppName=Glasses Code Counter
AppVersion=1.1
AppPublisher=Scott Clayton
AppPublisherURL=http://code.google.com/p/glasses-code-counter/
AppSupportURL=http://code.google.com/p/glasses-code-counter/
AppUpdatesURL=http://code.google.com/p/glasses-code-counter/
DefaultDirName={pf}\Glasses Code Counter
DefaultGroupName=Glasses Code Counter
OutputDir=.
OutputBaseFilename=setupglasses
SetupIconFile=.\Art\icon001.ico
Compression=lzma
SolidCompression=yes
WizardImageFile=.\Art\setup.bmp
WizardSmallImageFile=.\Art\setupsmall.bmp

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: ".\CodeCounter2\bin\Release\CodeCounter2.exe"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\Glasses Code Counter"; Filename: "{app}\CodeCounter2.exe"
Name: "{group}\{cm:ProgramOnTheWeb,Glasses Code Counter}"; Filename: "http://code.google.com/p/glasses-code-counter/"
Name: "{group}\{cm:UninstallProgram,Glasses Code Counter}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\Glasses Code Counter"; Filename: "{app}\CodeCounter2.exe"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\Glasses Code Counter"; Filename: "{app}\CodeCounter2.exe"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\CodeCounter2.exe"; Description: "{cm:LaunchProgram,Glasses Code Counter}"; Flags: nowait postinstall skipifsilent

