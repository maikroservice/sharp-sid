# sharp-SID

sharp-SID allows you to translate a SID to an Active Directory username 

The idea arose from the following problem - if a local security group is modified the raw event will only hold the SID of the affected object.
This unfortunately does not help when trying to identify if the new addition to the local administator group on your domain controller was malicious or not 😅

Because the SIEM we are using does not allow us to run powershell natively in response to alerts we needed an option to convert the SIDs to usernames so that we could easily identify what the added/removed user or group was. 

## usage
```
.\sharp-sid.exe S-1-5-21-3038678502-2606483612-2102760836-1627

// or more general
.\sharp-sid.exe <your_SID_to_be_resolved_goes_here>
```

This needs to be executed on a domain joined computer or the affected machine to resolve the SID properly.