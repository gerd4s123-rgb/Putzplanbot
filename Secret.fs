module Secret

open System
open Types

// 1) Telegram Bot Token (nach Revoke den neuen eintragen)
let Token = Environment.GetEnvironmentVariable "7956346228:AAHK-54f6okMszcEPvun16k_pdZXMPHImU0"

// 2) WG-Mitglieder (aus getUpdates: from.id)
let allFlatmates : Flatmate list =
    [
        { Name = "Johannes"; Id = 901641945L }
        { Name = "Claudius"; Id = 6193832903L }
        { Name = "Katharina"; Id = 875561710L }
    ]

// 3) Gruppen-Chat-ID (aus getUpdates: chat.id)
let defaultMainChat : int64 = -4181313766L

// 4) Initialer Putzplan (Beispiel-Aufgaben)
let initialPutzplan : Putzplan =
    [
        { CurrentPerson = Some allFlatmates[0]
          LastDone = None
          LastReminded = None
          Interval = 7
          Priority = Low
          Name = "Bad"
          Desc = Some "Bad putzen"
          Order = allFlatmates }

        { CurrentPerson = Some allFlatmates[1]
          LastDone = None
          LastReminded = None
          Interval = 7
          Priority = Low
          Name = "Küche"
          Desc = Some "Küche putzen"
          Order = allFlatmates }

        { CurrentPerson = Some allFlatmates[2]
          LastDone = None
          LastReminded = None
          Interval = 7
          Priority = Low
          Name = "Müll"
          Desc = Some "Müll rausbringen"
          Order = allFlatmates }
    ]
