https://adsecurity.org/?page_id=4031

urce for Detecting & Defending against attacks.  
I provide references for the attacks and a number of defense & detection techniques.

**Active Directory & Windows Security**

**ATTACK**

AD Recon

- [Active Directory Recon Without Admin Rights](https://adsecurity.org/?p=2535)
- [SPN Scanning – Service Discovery without Network Port Scanning](https://adsecurity.org/?p=1508)
- [Beyond Domain Admins – Domain Controller & AD Administration](https://adsecurity.org/?p=3700)
- [Scanning for Active Directory Privileges & Privileged Accounts](https://adsecurity.org/?p=3658)
- [Active Directory Recon with PowerUpSQL](https://blog.netspi.com/dumping-active-directory-domain-info-with-powerupsql/)
- [PowerView Usage Reference Posts by Harmj0y](https://www.harmj0y.net/blog/tag/powerview/)
- [PowerView one-liners (GitHub)](https://gist.github.com/HarmJ0y/184f9822b195c52dd50c379ed3117993#file-powerview-3-0-tricks-ps1-L20-L21)
- [Enumeration using the Meterpreter ADSI Extended API Commands](https://www.darkoperator.com/blog/2014/1/29/enumeration-using-the-meterpreter-adsi-extended-api-commands)

DCSync

- [DCSync: Attack & Detection](https://adsecurity.org/?p=1729)

DCShadow

- [DCShadow.com](https://www.dcshadow.com/)
- [DCShadow explained: A technical deep dive into the latest AD attack technique](https://blog.alsid.eu/dcshadow-explained-4510f52fc19d)

DPAPI

- [Operational Guidance for Offensive User DPAPI Abuse](https://www.harmj0y.net/blog/redteaming/operational-guidance-for-offensive-user-dpapi-abuse/) 

Attacking Active Directory

- [A Guide to Attacking Domain Trusts](https://www.harmj0y.net/blog/redteaming/a-guide-to-attacking-domain-trusts/)
- [Sneaky Active Directory Persistence #17: Group Policy](https://adsecurity.org/?p=2716)
- [MS15-011 & MS15-014: Microsoft Active Directory Group Policy (GPO) Vulnerabilities](https://adsecurity.org/?p=1405)
- [How Attackers Pull the Active Directory Database (NTDS.dit) from a Domain Controller](https://adsecurity.org/?p=451)
- [Practical Guide to NTLM Relaying](https://byt3bl33d3r.github.io/practical-guide-to-ntlm-relaying-in-2017-aka-getting-a-foothold-in-under-5-minutes.html)
- [Microsoft ATA Guide to Suspicious Activity](https://docs.microsoft.com/en-us/advanced-threat-analytics/suspicious-activity-guide)
- [Beyond LLMNR/NBNS Spoofing – Exploiting Active Directory-Integrated DNS](https://blog.netspi.com/exploiting-adidns/)

Active Directory Privilege Escalation:

- [Attack Methods for Gaining Domain Admin Rights in Active Directory](https://adsecurity.org/?p=2362)
- [Finding Passwords in SYSVOL & Exploiting Group Policy Preferences](https://adsecurity.org/?p=2288)
- [How Attackers Dump Active Directory Database Credentials](https://adsecurity.org/?p=2398)
- [The Most Common Active Directory Security Issues and What You Can Do to Fix Them](https://adsecurity.org/?p=1684)
- [Attacking Read-Only Domain Controllers (RODCs) to Own Active Directory](https://adsecurity.org/?p=3592)
- [From DNSAdmins to Domain Admin, When DNSAdmins is More than Just DNS Administration](https://adsecurity.org/?p=4064)
- [Domain Controller running Print Server + Unconstrained Delegation = AD Domain Compromise](https://youtu.be/-bcWZQCLk_4?t=2194) \[[PoC](https://github.com/leechristensen/SpoolSample)\]
- [Top Five Ways I Got Domain Admin on Your Internal Network before Lunch (2018 edition)](https://medium.com/@adam.toscher/top-five-ways-i-got-domain-admin-on-your-internal-network-before-lunch-2018-edition-82259ab73aaa)
- [Windows Privilege Escalation Part 2: Domain Admin Privileges](https://blog.netspi.com/windows-privilege-escalation-part-2-domain-admin-privileges/)

Kerberos (AD) Attacks

- [Kerberos Unconstrained Delegation (or How Compromise of a Single Server Can Compromise the Domain)](https://adsecurity.org/?p=1667)
- [Kerberos Vulnerability in MS14-068 (KB3011780) Explained](https://adsecurity.org/?p=541)
- [Kerberoast/Kerberoasting: Attack & Detection](https://adsecurity.org/?p=3458)
- [Targeted Kerberoasting](https://www.harmj0y.net/blog/activedirectory/targeted-kerberoasting/) 
- [Kerberoasting without Mimikatz](https://www.harmj0y.net/blog/powershell/kerberoasting-without-mimikatz/) 
- [Roasting AS-REPs (Harmj0y)](https://www.harmj0y.net/blog/activedirectory/roasting-as-reps/)
- [S4U2Pwnage](https://www.harmj0y.net/blog/activedirectory/s4u2pwnage/) 
- [Oracle AD attribute contains hashed version of AD account (user/computer) password](https://www.trustedsec.com/2018/10/w32-coozie-discovering-oracle-cve-2018-3253/)

Forged Kerberos Tickets

- [Computer Accounts & Domain Controller Silver Tickets](https://adsecurity.org/?p=2753)
- [How Attackers Use Kerberos Silver Tickets to Exploit Systems](https://adsecurity.org/?p=2011)
- [Kerberos Golden Tickets are Now More Golden](https://adsecurity.org/?p=1640)

**DEFENSE**

Windows Security

- [Securing Domain Controllers to Improve Active Directory Security](https://adsecurity.org/?p=3377)
- [Securing Windows Workstations: Developing a Secure Baseline](https://adsecurity.org/?p=3299)
- [Microsoft KB2871997: Back-Porting Windows 8.1/Win2012R2 Enhanced Security & Pass The Hash Mitigation to Windows 7, Windows 8, & Windows 2008R2](https://adsecurity.org/?p=559)
- [Demystifying the Windows Firewall – Learn how to irritate attackers without crippling your network (Jessica Payne’s speaks at Ignite)](https://channel9.msdn.com/Events/Ignite/New-Zealand-2016/M377)
- [Endpoint Isolation with the Windows Firewall](https://medium.com/@cryps1s/endpoint-isolation-with-the-windows-firewall-462a795f4cfb)

Windows 10 Security

- [Security baseline (DRAFT) for Windows 10 v1809 and Windows Server 2019](https://blogs.technet.microsoft.com/secguide/2018/10/01/security-baseline-draft-for-windows-10-v1809-and-windows-server-2019/)
- [Security baseline for Windows 10 “April 2018 Update” (v1803) – FINAL](https://blogs.technet.microsoft.com/secguide/2018/04/30/security-baseline-for-windows-10-april-2018-update-v1803-final/) 
- [Security baseline for Windows 10 “Creators Update” (v1703) – FINAL](https://blogs.technet.microsoft.com/secguide/2017/08/30/security-baseline-for-windows-10-creators-update-v1703-final/)
- [Windows 10 ExploitGuard Attack Surface Reduction Rules](https://docs.microsoft.com/en-us/windows/security/threat-protection/windows-defender-exploit-guard/attack-surface-reduction-exploit-guard)
- [Microsoft Policy Analyzer (for comparing GPO settings)](https://blogs.technet.microsoft.com/secguide/2018/06/29/policy-analyzer-minor-update/)

Windows Event Auditing

- [Microsoft Docs: Advanced security audit policy settings (great event log resource)](https://docs.microsoft.com/en-us/windows/security/threat-protection/auditing/advanced-security-audit-policy-settings)
- [Microsoft Windows IT Pro Docs on Github: windows-itpro-docs/windows/security/threat-protection/auditing/](https://github.com/MicrosoftDocs/windows-itpro-docs/tree/master/windows/security/threat-protection/auditing)
- [Monitoring what matters – Windows Event Forwarding for everyone (even if you already have a SIEM.)](https://blogs.technet.microsoft.com/jepayne/2015/11/23/monitoring-what-matters-windows-event-forwarding-for-everyone-even-if-you-already-have-a-siem/)

Effective Defenses & Hunting

- [Manage Local Administrator Account Passwords: Microsoft Local Administrator Password Solution (LAPS)](https://adsecurity.org/?p=1790)
- [Active Directory Threat Hunting – Effective AD Event Auditing](https://trimarcsecurity.com/transcript-detecting-the-elusive-active-directory-threat-hunting-seanmetcalf): [Video](https://www.youtube.com/watch?v=9Uo7V9OUaUw) & [Slides](https://adsecurity.org/wp-content/uploads/2017/04/2017-BSidesCharm-DetectingtheElusive-ActiveDirectoryThreatHunting-Final.pdf)
- [Build a fast, free, and effective Threat Hunting/Incident Response Console with Windows Event Forwarding and PowerBI (aka “Weffles”)](https://blogs.technet.microsoft.com/jepayne/2017/12/08/weffles/)
- [Hunting With Active Directory Replication Metadata](https://www.harmj0y.net/blog/defense/hunting-with-active-directory-replication-metadata/) 
- [Basics of Tracking WMI Activity](https://www.darkoperator.com/blog/2017/10/14/basics-of-tracking-wmi-activity)
- [Presentation of SLAM and Lateral Movement (Channel9 video with Jessica Payne)](https://aka.ms/toppopslam)
- [Tracking Lateral Movement Part One – Special Groups and Specific Service Accounts](https://blogs.technet.microsoft.com/jepayne/2015/11/26/tracking-lateral-movement-part-one-special-groups-and-specific-service-accounts/)

Application Whitelisting Resources

- [“AaronLocker” update (v0.91) — and see “AaronLocker” in action on Channel 9!](https://blogs.msdn.microsoft.com/aaron_margosis/2018/10/11/aaronlocker-update-v0-91-and-see-aaronlocker-in-action-on-channel-9/)

Building Robust Detection

- [Lessons Learned in Detection Engineering](https://medium.com/starting-up-security/lessons-learned-in-detection-engineering-304aec709856)
- [Alerting and Detection Strategy Framework](https://medium.com/palantir/alerting-and-detection-strategy-framework-52dc33722df2)
- [A SOCless Detection Team at Netflix](https://www.linkedin.com/pulse/socless-detection-team-netflix-alex-maestretti/)
- [Detecting Windows Endpoint Compromise with SACLs](https://medium.com/@cryps1s/detecting-windows-endpoint-compromise-with-sacls-cd748e10950)
- [Automated Collection and Enrichment](https://github.com/Invoke-IR/ACE/)
- [The HELK](https://github.com/Cyb3rWard0g/HELK/wiki) 

**ADFS**

- [Securing Microsoft Active Directory Federation Server (ADFS)](https://adsecurity.org/?p=3782)

**POWERSHELL**

- [PowerShell Attack & Detection](https://adsecurity.org/?p=2921)
- [Malicious PowerShell Detection with Machine Learning (FireEye)](https://www.fireeye.com/blog/threat-research/2018/07/malicious-powershell-detection-via-machine-learning.html)
- [Defending Against PowerShell Attacks (Microsoft)](https://blogs.msdn.microsoft.com/powershell/2017/10/23/defending-against-powershell-attacks/)
- [Revoke-Obfuscation: PowerShell Obfuscation Detection Using Science (Black Hat whitepaper by Daniel Bohannon & Lee Holmes)](https://www.blackhat.com/docs/us-17/thursday/us-17-Bohannon-Revoke-Obfuscation-PowerShell-Obfuscation-Detection-And%20Evasion-Using-Science-wp.pdf)

**TOOLS**

- [Mimikatz](https://github.com/gentilkiwi/mimikatz): [Info](https://adsecurity.org/?page_id=1821)
- [Kekeo](https://github.com/gentilkiwi/kekeo)
- [ADRecon](https://github.com/sense-of-security/ADRecon): PowerShell recon tool for AD
- [Bloodhound](https://github.com/BloodHoundAD/Bloodhound/wiki): Map out AD permissions & rights via graphs
- [CrackMapExec](https://github.com/byt3bl33d3r/CrackMapExec): Pentesting toolkit
- [DeathStar](https://github.com/byt3bl33d3r/DeathStar): A Python script to auto-pwn Active Directory
- Impacket: Collection of pentesting python tools
- [Inveigh](https://github.com/Kevin-Robertson/Inveigh): PowerShell tool to get network creds
- [MicroBurst](https://github.com/NetSPI/MicroBurst): Tool for assessing Azure security
- [PingCastle](https://www.pingcastle.com/download/): Tool for evaluating Active Directory security
- [PowerView](https://github.com/PowerShellMafia/PowerSploit/tree/master/Recon): PowerShell AD recon
- [PSAttack](https://github.com/jaredhaight/PSAttack): PowerShell attack tools in an EXE
- [Responder](https://github.com/SpiderLabs/Responder): The easy button for getting network creds
- [Rubeus](https://github.com/GhostPack/Rubeus): the C# port of Kekeo [Info](https://www.harmj0y.net/blog/redteaming/from-kekeo-to-rubeus/) & [Updates](https://www.harmj0y.net/blog/redteaming/rubeus-now-with-more-kekeo/)
- [Seatbelt](https://github.com/GhostPack/Seatbelt): Host survey tool
- [SharpSploit](https://github.com/cobbr/SharpSploit): a partial C# port of PowerSploit

**TWITTER ACCOUNTS TO FOLLOW**

- Aaron Margosis [@AaronMargosis](https://twitter.com/AaronMargosis) – co-author with Mark Russinovich on SysInternal books (and topics), publishes the Microsoft Windows security baselines (Windows 10, Windows Server 2016, etc), and AaronLocker (simpler method of deploying AppLocker).
- Andy Robbins [@\_wald0](https://twitter.com/_wald0) & Rohan Vazarkar [@cptjesus](https://twitter.com/CptJesus) – wrote Bloodhound
- Benjamin Delpy [@gentilkiwi](https://twitter.com/gentilkiwi) – wrote Mimikatz & Kekeo
- Carlos Perez [@Carlos\_Perez](https://twitter.com/Carlos_Perez) – Red/Blue/Purple teamer focused on Windows & AD security and more (& Microsoft MVP)
- Dane [@cryps1s](https://twitter.com/cryps1s) – has published real-world Windows firewall, Windows Event Forwarding (WEF) references, and other Windows security topics.
- DirectoryRanger [@DirectoryRanger](https://twitter.com/DirectoryRanger) – tweets out useful info relating to AD security
- Jason Fossen [@JasonFossen](https://twitter.com/JasonFossen) – SANS Instructor on Windows security topics
- Jess Dodson [@girlgerms](https://twitter.com/girlgerms) – blogger & speaker on Active Directory security topics (& Microsoft MVP)
- Jessica Payne [@jepayneMSFT](https://twitter.com/jepayneMSFT) – has promoted the use of the Windows Firewall and created WEFFLES.
- Lee Christensen [@tifkin\_](https://twitter.com/tifkin_) – wrote many cool tools like unmanaged PowerShell used in most attack tools & discovered the [DC Print Service/Unconstrained delegation privilege escalation](https://adsecurity.org/?p=4056).
- Marcello [@byt3bl33d3r](https://twitter.com/byt3bl33d3r) – publishes offensive Windows & AD tools like [CrackMapExec](https://github.com/byt3bl33d3r/CrackMapExec), [DeathStar](https://github.com/byt3bl33d3r/DeathStar), [Password Spraying Toolkit](https://github.com/byt3bl33d3r/SprayingToolkit), etc.
- Matt Graeber [@mattifestation](https://twitter.com/mattifestation) – founded PowerSploit, documented Device Guard, and numerous PowerShell and Device Guard bypasses (& Microsoft MVP)
- Matt Nelson [@enigma0x3](https://twitter.com/enigma0x3) – discovered numerous Windows vulnerabilities and privilege escalations (top 100 Microsoft security researchers)
- Oddvar Moe [@Oddvarmoe](https://twitter.com/Oddvarmoe) – Windows security researcher (& Microsoft MVP)
- Sean Metcalf [@PyroTek3](https://twitter.com/PyroTek3) – maintainer of ADSecurity.org and AD enthusiast.
- SwiftOnSecurity [@SwiftonSecurity](https://twitter.com/SwiftOnSecurity) – the parody account that’s worth following. Tons of Windows advice and recommendations not found elsewhere based on real world experience (& Microsoft MVP)
- Vincent LeToux [@mysmartlogon](https://twitter.com/mysmartlogon) – wrote the DCSync & DCShadow components in Mimikatz
- Will [@Harmj0y](https://twitter.com/harmj0y) – wrote PowerView, the original Bloodhound ingest PowerShell script, Rubeus and more!  (& Microsoft MVP)
- Microsoft Azure AD [@AzureAD](https://twitter.com/azuread) – Microsoft’s Azure Active Directory account tweets info about… Azure AD topics.

Don’t follow [@NerdPyle](https://twitter.com/NerdPyle) since he doesn’t talk AD anymore. 😉

_(I’m sure there are a bunch I forgot)_

**[MITRE ATT&CK](https://attack.mitre.org/wiki/Main_Page) ACTIVE DIRECTORY RELATED ELEMENTS**

- [Account Discovery](https://attack.mitre.org/wiki/Technique/T1087)
- [Account Manipulation](https://attack.mitre.org/wiki/Technique/T1098)
- [Credential Dumping](https://attack.mitre.org/wiki/Technique/T1003)
- [DCShadow](https://attack.mitre.org/wiki/Technique/T1207)
- [Exploitation for Credential Access](https://attack.mitre.org/wiki/Technique/T1212)
- [Exploitation of Remote Services](https://attack.mitre.org/wiki/Technique/T1210)
- [Kerberoasting](https://attack.mitre.org/wiki/Technique/T1208)
- [LLMNR/NBT-NS Poisoning](https://attack.mitre.org/wiki/Technique/T1171)
- [Logon Scripts](https://attack.mitre.org/wiki/Technique/T1037)
- [LSASS Driver](https://attack.mitre.org/wiki/Technique/T1177)
- [Network Service Scanning](https://attack.mitre.org/wiki/Technique/T1046)
- [Network Sniffing](https://attack.mitre.org/wiki/Technique/T1040)
- [Network Share Discovery](https://attack.mitre.org/wiki/Technique/T1135)
- [Pass the Hash (PTH)](https://attack.mitre.org/wiki/Technique/T1075)
- [Pass the Ticket (PTT)](https://attack.mitre.org/wiki/Technique/T1097)
- [Password Filter DLL](https://attack.mitre.org/wiki/Technique/T1174)
- [Password Policy Discovery](https://attack.mitre.org/wiki/Technique/T1201)
- [Permission Group Discovery](https://attack.mitre.org/wiki/Technique/T1069)
- [Privilege Escalation](https://attack.mitre.org/wiki/Privilege_Escalation)
- [Remote System Discovery](https://attack.mitre.org/wiki/Technique/T1018)
- [Security Support Provider](https://attack.mitre.org/wiki/Technique/T1101)
- [SID History Injection](https://attack.mitre.org/wiki/Technique/T1178)
- [System Network Configuration Discovery](https://attack.mitre.org/wiki/Technique/T1016)
- [Two-Factor Authentication Interception](https://attack.mitre.org/wiki/Technique/T1111)
- [Windows Admin Shares](https://attack.mitre.org/wiki/Technique/T1077)
- [Windows Management Instrumentation (WMI)](https://attack.mitre.org/wiki/Technique/T1047)
- [Windows Remote Management (WinRM)](https://attack.mitre.org/wiki/Technique/T1028)