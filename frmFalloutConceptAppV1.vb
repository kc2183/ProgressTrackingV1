' Program Name:     Fallout Concept Application V1
' Developer:        kc2183
' Date:             February 7, 2021
' Purpose:          This application displays three buttons to the user, pertaining to three categories of information,
'                   which they can click on to see five subcategories of information related to the parent category of
'                   their choosing. After selecting a subcategory, more buttons related to that subcategory become
'                   available, which each display specific text entries of relevant information when clicked. Not all
'                   of the categories are complete - this project is intentionally incomplete as it is only meant to
'                   act as documentation of my learning progress. Further details and notes are included below.

'                       This application is the first of an undetermined number of iterations meant to act as a sort
'                   of documentation of my understanding of the things I'm learning as I progress through my courses. 
'                   My intent is to approximately emulate a user interface I'm familiar with (the Fallout Pip-Boy)
'                   using the things I've learned so far, and to create new iterations every so often to serve as
'                   "bookmark" examples of my progress and for my own reference to understand how my approach to
'                   development and design evolves over time, so that I might learn from my mistakes (for example,
'                   by finding more efficient ways to address the problems I ran into in previous versions) and more
'                   quickly adapt to the structure of Visual Studio (by recreating something I'm familiar with and
'                   have certain expectations for that I want to reproduce I think I'll learn more easily how to
'                   work with the tools available to me in ways that I understand.)
'                       The purpose of this application (along with the ones following) is to determine how well I'm
'                   able to emulate the UI of the "Pip-Boy" device from the video game franchise "Fallout" - which I'm
'                   accustomed to using from playing games in the series and using the Pip-Boy to navigate its different
'                   categories and subcategories which display information to the user and allow different contextual
'                   actions (like viewing, using, and dropping items from the inventory, selecting a radio station to
'                   listen to, or reviewing objectives, or placing map markers, etc.) - it's an interesting example
'                   of a UI because it performs numerous functions and is integral to the playability of the game,
'                   acting as an always-accessible general overview of the game's current state and making nearly all
'                   the information the player might need only a few clicks away and presented in a very simple and
'                   easy-to-navigate layout. For those reasons, I think it will be a good template for the purposes
'                   I outlined above. Additionally, the information used for this project will be specifically related
'                   to "Fallout: New Vegas" because that's the one I'm playing now, hahah. The UI layout is also based
'                   on the "Pip-Boy 3000" version of the Pip-Boy, the general layout being: 3 buttons on the bottom, 5
'                   tabs above the buttons on a screen, and a vertical list of entries of information placed on the left
'                   side of the screen with the related details being placed in a column to the right (all located above
'                   the tabs which remain highlighted while their subcategory is still selected).
'                       Obviously I won't be able to recreate very much about it right now besides the general layout,
'                   but that's the whole point of seeing how much I can do! In this version, I've used button click
'                   events, the form load event, labels, visibility, etc. that I've learned from the book so far. I
'                   also am experimenting with the document outline window and split containers - which I haven't
'                   learned about yet but out of necessity I think I've figured them out enough for my purposes. That
'                   will be something I'll need to revisit later however, when I learn the correct way of doing things.
'                   Maybe my way will be correct enough for what I'm making for now, but I'm afraid that the way I'm
'                   layering the controls and containers, and using the containers as a visibility property shortcut,
'                   isn't at all intended and may cause me issues later. I'll see I guess!
'                       Something I 've learned so far is that Visual Studio lacks the sort of interface/management
'                   type of thing that I'm used to in digital art kinds of programs, as in like a way to group objects
'                   into folders(my workaround for that at the moment is the split containers because they allow me to
'                   collapse sections of controls in the document outline window) or toggle visibility (in the design
'                   view, not in the application itself) of controls/groups of controls, which I had already noticed
'                   previously but it hadn't been important for the book's projects so far, but is practically necessary
'                   for what I'm making now. That would be very useful, but I'll have to find a way to keep track of
'                   things in the way that I need to (to focus on what I'm doing and track my progress) using something
'                   outside of VS for the time being. However, on the bright side of things, the problems I created for
'                   myself (lol) led me to learning how to code the events for a control without being able to directly
'                   double-click on it (most of the buttons here aren't visible - but I can select them in the document
'                   outline window and click the little Events lightning bolt and double-click the Click event on there)!
'                   The book may have actually told me that, but I'd have to go back and see, and either way I won't
'                   have to learn it again! I know that this isn't a long-term solution for this problem as it pertains
'                   to this overall project, though, because I know if I needed to change the appearance of the controls
'                   it would be a huge hassle to have to move the order around and all of that unless I did it all at
'                   the start - so I probably won't be doing any adjusting of the fonts and colors and things unless
'                   I discover a better way to do this stuff later!

'   [info below is for my own reference while coding]
'   *note that the main three split containers need to
'    be layered below the containers "within" them in
'    order for things to be displayed properly (split
'    containers were a bad choice)

'       btnSTATS                                                        > STATS button
'           splSTATS
'               btnSTATSStatus                                         >> Status button
'                   splSTATSStatus
'                       btnSTATSStatusCND                             >>> CND button
'                           lblSTATSStatusCND
'                       btnSTATSStatusRAD                             >>> RAD button
'                           lblSTATSStatusRAD
'                       btnSTATSStatusEFF                             >>> EFF button
'                           lblSTATSStatusEFF
'               btnSTATSSpecial                                        >> S.P.E.C.I.A.L. button
'                   splSTATSSpecial
'                       btnSTATSSpecialStrength                       >>> Strength button
'                           lblSTATSSpecialStrength
'                       btnSTATSSpecialPerception                     >>> Perception button
'                           lblSTATSSpecialPerception
'                       btnSTATSSpecialEndurance                      >>> Endurance button
'                           lblSTATSSpecialEndurance
'                       btnSTATSSpecialCharisma                       >>> Charisma button
'                           lblSTATSSpecialCharisma
'                       btnSTATSSpecialIntelligence                   >>> Intelligence button
'                           lblSTATSSpecialIntelligence
'                       btnSTATSSpecialAgility                        >>> Agility button
'                           lblSTATSSpecialAgility
'                       btnSTATSSpecialLuck                           >>> Luck button
'                           lblSTATSSpecialLuck
'               btnSTATSSkills                                         >> Skills button
'                   splSTATSSkills
'                       btnSTATSSkillsBarter                          >>> Barter button
'                           lblSTATSSkillsBarter
'                       btnSTATSSkillsEnergyWeapons                   >>> Energy Weapons button
'                           lblSTATSSkillsEnergyWeapons
'                       btnSTATSSkillsExplosives                      >>> Explosives button
'                           lblSTATSSkillsExplosives
'                       btnSTATSSkillsGuns                            >>> Guns button
'                           lblSTATSSkillsGuns
'                       btnSTATSSkillsLockpick                        >>> Lockpick button
'                           lblSTATSSkillsLockpick
'                       btnSTATSSkillsMedicine                        >>> Medicine button
'                           lblSTATSSkillsMedicine
'                       btnSTATSSkillsMeleeWeapons                    >>> Melee Weapons button
'                           lblSTATSSkillsMeleeWeapons
'                       btnSTATSSkillsRepair                          >>> Repair button
'                           lblSTATSSkillsRepair
'                       btnSTATSSkillsScience                         >>> Science button
'                           lblSTATSSkillsScience
'                       btnSTATSSkillsSneak                           >>> Sneak button
'                           lblSTATSSkillsSneak
'                       btnSTATSSkillsSpeech                          >>> Speech button
'                           lblSTATSSkillsSpeech
'                       btnSTATSSkillsSurvival                        >>> Survival button
'                           lblSTATSSkillsSurvival
'                       btnSTATSSkillsUnarmed                         >>> Unarmed button
'                           lblSTATSSkillsUnarmed
'               btnSTATSPerks                                          >> Perks button
'                   splSTATSPerks
'                       lblSTATSPerks
'               btnSTATSGeneral                                        >> General button
'                   splSTATSGeneral
'                       btnSTATSGeneralBoomers                        >>> Boomers button
'                           lblSTATSGeneralBoomers
'                       btnSTATSGeneralBrotherhood                    >>> Brotherhood of Steel button
'                           lblSTATSGeneralBrotherhood
'                       btnSTATSGeneralLegion                         >>> Caesar's Legion button
'                           lblSTATSGeneralLegion
'                       btnSTATSGeneralFollowers                      >>> Followers of the Apocalypse button
'                           lblSTATSGeneralFollowers
'                       btnSTATSGeneralFreeside                       >>> Freeside button
'                           lblSTATSGeneralFreeside
'                       btnSTATSGeneralGoodsprings                    >>> Goodsprings button
'                           lblSTATSGeneralGoodsprings
'                       btnSTATSGeneralGreatKhans                     >>> Great Khans button
'                           lblSTATSGeneralGreatKhans
'                       btnSTATSGeneralNCR                            >>> NCR button
'                           lblSTATSGeneralNCR
'                       btnSTATSGeneralNovac                          >>> Novac button
'                           lblSTATSGeneralNovac
'                       btnSTATSGeneralPowderGangers                  >>> Powder Gangers button
'                           lblSTATSGeneralPowderGangers
'                       btnSTATSGeneralPrimm                          >>> Primm button
'                           lblSTATSGeneralPrimm
'                       btnSTATSGeneralStrip                          >>> The Strip button
'                           lblSTATSGeneralStrip
'                       btnSTATSGeneralWhiteGlove                     >>> White Glove Society button
'                           lblSTATSGeneralWhiteGlove
'       btnITEMS                                                        > ITEMS button
'           splITEMS
'               btnITEMSWeapons                                        >> Weapons button
'                   splITEMSWeapons
'                       lblITEMSWeapons
'               btnITEMSApparel                                        >> Apparel button
'                   splITEMSApparel
'                       lblITEMSApparel
'               btnITEMSAid                                            >> Aid button
'                   splITEMSAid
'                       lblITEMSAid
'               btnITEMSMisc                                           >> Misc button
'                   splITEMSMisc
'                       lblITEMSMisc
'               btnITEMSAmmo                                           >> Ammo button
'                   splITEMSAmmo
'                       lblITEMSAmmo
'       btnDATA                                                         > DATA button
'           splDATA
'               btnDATALocalMap                                        >> Local Map button
'                   splDATALocalMap
'                       lblDATALocalMap
'               btnDATAWorldMap                                        >> World Map button
'                   splDATAWorldMap
'                       lblDATAWorldMap
'               btnDATAQuests                                          >> Quests button
'                   splDATAQuests
'                       lblDATAQuests
'               btnDATAMisc                                            >> Misc button
'                   splDATAMisc
'                       lblDATAMisc
'               btnDATARadio                                           >> Radio button
'                   splDATARadio
'                       lblDATARadio

Public Class frmFalloutConceptAppV1
    Private Sub frmFalloutConceptAppV1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' enable the main three buttons
        btnSTATS.Enabled = True
        btnITEMS.Enabled = True
        btnDATA.Enabled = True
        ' hide all split containers
        splSTATS.Visible = False
        splSTATSStatus.Visible = False
        splSTATSSpecial.Visible = False
        splSTATSSkills.Visible = False
        splSTATSPerks.Visible = False
        splSTATSGeneral.Visible = False
        splITEMS.Visible = False
        splITEMSWeapons.Visible = False
        splITEMSApparel.Visible = False
        splITEMSAid.Visible = False
        splITEMSMisc.Visible = False
        splITEMSAmmo.Visible = False
        splDATA.Visible = False
        splDATALocalMap.Visible = False
        splDATAWorldMap.Visible = False
        splDATAQuests.Visible = False
        splDATAMisc.Visible = False
        splDATARadio.Visible = False
    End Sub

    Private Sub btnSTATS_Click(sender As Object, e As EventArgs) Handles btnSTATS.Click
        ' disable the button clicked
        btnSTATS.Enabled = False
        ' enable the other two main buttons
        btnITEMS.Enabled = True
        btnDATA.Enabled = True
        ' display the split container holding the relevant buttons
        splSTATS.Visible = True
        ' hide all other split containers
        splSTATSStatus.Visible = False
        splSTATSSpecial.Visible = False
        splSTATSSkills.Visible = False
        splSTATSPerks.Visible = False
        splSTATSGeneral.Visible = False
        splITEMS.Visible = False
        splITEMSWeapons.Visible = False
        splITEMSApparel.Visible = False
        splITEMSAid.Visible = False
        splITEMSMisc.Visible = False
        splITEMSAmmo.Visible = False
        splDATA.Visible = False
        splDATALocalMap.Visible = False
        splDATAWorldMap.Visible = False
        splDATAQuests.Visible = False
        splDATAMisc.Visible = False
        splDATARadio.Visible = False
        ' enable the relevant buttons
        btnSTATSStatus.Enabled = True
        btnSTATSSpecial.Enabled = True
        btnSTATSSkills.Enabled = True
        btnSTATSPerks.Enabled = True
        btnSTATSGeneral.Enabled = True
    End Sub

    Private Sub btnSTATSStatus_Click(sender As Object, e As EventArgs) Handles btnSTATSStatus.Click
        ' disable the button clicked
        btnSTATSStatus.Enabled = False
        ' enable the other buttons
        btnSTATSSpecial.Enabled = True
        btnSTATSSkills.Enabled = True
        btnSTATSPerks.Enabled = True
        btnSTATSGeneral.Enabled = True
        ' display the relevant container
        splSTATSStatus.Visible = True
        ' hide the remaining containers of this group
        splSTATSSpecial.Visible = False
        splSTATSSkills.Visible = False
        splSTATSPerks.Visible = False
        splSTATSGeneral.Visible = False
        ' enable the relevant buttons
        btnSTATSStatusCND.Enabled = True
        btnSTATSStatusRAD.Enabled = True
        btnSTATSStatusEFF.Enabled = True
        ' hide all relevant labels
        lblSTATSStatusCND.Visible = False
        lblSTATSStatusRAD.Visible = False
        lblSTATSStatusEFF.Visible = False
    End Sub

    Private Sub btnSTATSStatusCND_Click(sender As Object, e As EventArgs) Handles btnSTATSStatusCND.Click
        ' disable the button clicked
        btnSTATSStatusCND.Enabled = False
        ' enable the other buttons
        btnSTATSStatusRAD.Enabled = True
        btnSTATSStatusEFF.Enabled = True
        ' display the relevant label
        lblSTATSStatusCND.Visible = True
        ' hide the remaining labels within the container
        lblSTATSStatusRAD.Visible = False
        lblSTATSStatusEFF.Visible = False
    End Sub

    Private Sub btnSTATSStatusRAD_Click(sender As Object, e As EventArgs) Handles btnSTATSStatusRAD.Click
        ' disable the button clicked
        btnSTATSStatusRAD.Enabled = False
        ' enable the other buttons
        btnSTATSStatusCND.Enabled = True
        btnSTATSStatusEFF.Enabled = True
        ' display the relevant label
        lblSTATSStatusRAD.Visible = True
        ' hide the remaining labels within the container
        lblSTATSStatusCND.Visible = False
        lblSTATSStatusEFF.Visible = False
    End Sub

    Private Sub btnSTATSStatusEFF_Click(sender As Object, e As EventArgs) Handles btnSTATSStatusEFF.Click
        ' disable the button clicked
        btnSTATSStatusEFF.Enabled = False
        ' enable the other buttons
        btnSTATSStatusCND.Enabled = True
        btnSTATSStatusRAD.Enabled = True
        ' display the relevant label
        lblSTATSStatusEFF.Visible = True
        ' hide the remaining labels within the container
        lblSTATSStatusCND.Visible = False
        lblSTATSStatusRAD.Visible = False
    End Sub

    Private Sub btnSTATSSpecial_Click(sender As Object, e As EventArgs) Handles btnSTATSSpecial.Click
        ' disable the button clicked
        btnSTATSSpecial.Enabled = False
        ' enable the other buttons
        btnSTATSStatus.Enabled = True
        btnSTATSSkills.Enabled = True
        btnSTATSPerks.Enabled = True
        btnSTATSGeneral.Enabled = True
        ' display the relevant container
        splSTATSSpecial.Visible = True
        ' hide the remaining containers of this group
        splSTATSStatus.Visible = False
        splSTATSSkills.Visible = False
        splSTATSPerks.Visible = False
        splSTATSGeneral.Visible = False
        ' enable the relevant buttons
        btnSTATSSpecialStrength.Enabled = True
        btnSTATSSpecialPerception.Enabled = True
        btnSTATSSpecialEndurance.Enabled = True
        btnSTATSSpecialCharisma.Enabled = True
        btnSTATSSpecialIntelligence.Enabled = True
        btnSTATSSpecialAgility.Enabled = True
        btnSTATSSpecialLuck.Enabled = True
        ' hide all relevant labels
        lblSTATSSpecialStrength.Visible = False
        lblSTATSSpecialPerception.Visible = False
        lblSTATSSpecialEndurance.Visible = False
        lblSTATSSpecialCharisma.Visible = False
        lblSTATSSpecialIntelligence.Visible = False
        lblSTATSSpecialAgility.Visible = False
        lblSTATSSpecialLuck.Visible = False
    End Sub

    Private Sub btnSTATSSpecialStrength_Click(sender As Object, e As EventArgs) Handles btnSTATSSpecialStrength.Click
        ' disable the button clicked
        btnSTATSSpecialStrength.Enabled = False
        ' enable the other buttons
        btnSTATSSpecialPerception.Enabled = True
        btnSTATSSpecialEndurance.Enabled = True
        btnSTATSSpecialCharisma.Enabled = True
        btnSTATSSpecialIntelligence.Enabled = True
        btnSTATSSpecialAgility.Enabled = True
        btnSTATSSpecialLuck.Enabled = True
        ' display the relevant label
        lblSTATSSpecialStrength.Visible = True
        ' hide the remaining labels within the container
        lblSTATSSpecialPerception.Visible = False
        lblSTATSSpecialEndurance.Visible = False
        lblSTATSSpecialCharisma.Visible = False
        lblSTATSSpecialIntelligence.Visible = False
        lblSTATSSpecialAgility.Visible = False
        lblSTATSSpecialLuck.Visible = False
    End Sub

    Private Sub btnSTATSSpecialPerception_Click(sender As Object, e As EventArgs) Handles btnSTATSSpecialPerception.Click
        ' disable the button clicked
        btnSTATSSpecialPerception.Enabled = False
        ' enable the other buttons
        btnSTATSSpecialStrength.Enabled = True
        btnSTATSSpecialEndurance.Enabled = True
        btnSTATSSpecialCharisma.Enabled = True
        btnSTATSSpecialIntelligence.Enabled = True
        btnSTATSSpecialAgility.Enabled = True
        btnSTATSSpecialLuck.Enabled = True
        ' display the relevant label
        lblSTATSSpecialPerception.Visible = True
        ' hide the remaining labels within the container
        lblSTATSSpecialStrength.Visible = False
        lblSTATSSpecialEndurance.Visible = False
        lblSTATSSpecialCharisma.Visible = False
        lblSTATSSpecialIntelligence.Visible = False
        lblSTATSSpecialAgility.Visible = False
        lblSTATSSpecialLuck.Visible = False
    End Sub

    Private Sub btnSTATSSpecialEndurance_Click(sender As Object, e As EventArgs) Handles btnSTATSSpecialEndurance.Click
        ' disable the button clicked
        btnSTATSSpecialEndurance.Enabled = False
        ' enable the other buttons
        btnSTATSSpecialStrength.Enabled = True
        btnSTATSSpecialPerception.Enabled = True
        btnSTATSSpecialCharisma.Enabled = True
        btnSTATSSpecialIntelligence.Enabled = True
        btnSTATSSpecialAgility.Enabled = True
        btnSTATSSpecialLuck.Enabled = True
        ' display the relevant label
        lblSTATSSpecialEndurance.Visible = True
        ' hide the remaining labels within the container
        lblSTATSSpecialStrength.Visible = False
        lblSTATSSpecialPerception.Visible = False
        lblSTATSSpecialCharisma.Visible = False
        lblSTATSSpecialIntelligence.Visible = False
        lblSTATSSpecialAgility.Visible = False
        lblSTATSSpecialLuck.Visible = False
    End Sub

    Private Sub btnSTATSSpecialCharisma_Click(sender As Object, e As EventArgs) Handles btnSTATSSpecialCharisma.Click
        ' disable the button clicked
        btnSTATSSpecialCharisma.Enabled = False
        ' enable the other buttons
        btnSTATSSpecialStrength.Enabled = True
        btnSTATSSpecialPerception.Enabled = True
        btnSTATSSpecialEndurance.Enabled = True
        btnSTATSSpecialIntelligence.Enabled = True
        btnSTATSSpecialAgility.Enabled = True
        btnSTATSSpecialLuck.Enabled = True
        ' display the relevant label
        lblSTATSSpecialCharisma.Visible = True
        ' hide the remaining labels within the container
        lblSTATSSpecialStrength.Visible = False
        lblSTATSSpecialPerception.Visible = False
        lblSTATSSpecialEndurance.Visible = False
        lblSTATSSpecialIntelligence.Visible = False
        lblSTATSSpecialAgility.Visible = False
        lblSTATSSpecialLuck.Visible = False
    End Sub

    Private Sub btnSTATSSpecialIntelligence_Click(sender As Object, e As EventArgs) Handles btnSTATSSpecialIntelligence.Click
        ' disable the button clicked
        btnSTATSSpecialIntelligence.Enabled = False
        ' enable the other buttons
        btnSTATSSpecialStrength.Enabled = True
        btnSTATSSpecialPerception.Enabled = True
        btnSTATSSpecialEndurance.Enabled = True
        btnSTATSSpecialCharisma.Enabled = True
        btnSTATSSpecialAgility.Enabled = True
        btnSTATSSpecialLuck.Enabled = True
        ' display the relevant label
        lblSTATSSpecialIntelligence.Visible = True
        ' hide the remaining labels within the container
        lblSTATSSpecialStrength.Visible = False
        lblSTATSSpecialPerception.Visible = False
        lblSTATSSpecialEndurance.Visible = False
        lblSTATSSpecialCharisma.Visible = False
        lblSTATSSpecialAgility.Visible = False
        lblSTATSSpecialLuck.Visible = False
    End Sub

    Private Sub btnSTATSSpecialAgility_Click(sender As Object, e As EventArgs) Handles btnSTATSSpecialAgility.Click
        ' disable the button clicked
        btnSTATSSpecialAgility.Enabled = False
        ' enable the other buttons
        btnSTATSSpecialStrength.Enabled = True
        btnSTATSSpecialPerception.Enabled = True
        btnSTATSSpecialEndurance.Enabled = True
        btnSTATSSpecialCharisma.Enabled = True
        btnSTATSSpecialIntelligence.Enabled = True
        btnSTATSSpecialLuck.Enabled = True
        ' display the relevant label
        lblSTATSSpecialAgility.Visible = True
        ' hide the remaining labels within the container
        lblSTATSSpecialStrength.Visible = False
        lblSTATSSpecialPerception.Visible = False
        lblSTATSSpecialEndurance.Visible = False
        lblSTATSSpecialCharisma.Visible = False
        lblSTATSSpecialIntelligence.Visible = False
        lblSTATSSpecialLuck.Visible = False
    End Sub

    Private Sub btnSTATSSpecialLuck_Click(sender As Object, e As EventArgs) Handles btnSTATSSpecialLuck.Click
        ' disable the button clicked
        btnSTATSSpecialLuck.Enabled = False
        ' enable the other buttons
        btnSTATSSpecialStrength.Enabled = True
        btnSTATSSpecialPerception.Enabled = True
        btnSTATSSpecialEndurance.Enabled = True
        btnSTATSSpecialCharisma.Enabled = True
        btnSTATSSpecialIntelligence.Enabled = True
        btnSTATSSpecialAgility.Enabled = True
        ' display the relevant label
        lblSTATSSpecialLuck.Visible = True
        ' hide the remaining labels within the container
        lblSTATSSpecialStrength.Visible = False
        lblSTATSSpecialPerception.Visible = False
        lblSTATSSpecialEndurance.Visible = False
        lblSTATSSpecialCharisma.Visible = False
        lblSTATSSpecialIntelligence.Visible = False
        lblSTATSSpecialAgility.Visible = False
    End Sub

    Private Sub btnSTATSSkills_Click(sender As Object, e As EventArgs) Handles btnSTATSSkills.Click
        ' disable the button clicked
        btnSTATSSkills.Enabled = False
        ' enable the other buttons
        btnSTATSStatus.Enabled = True
        btnSTATSSpecial.Enabled = True
        btnSTATSPerks.Enabled = True
        btnSTATSGeneral.Enabled = True
        ' display the relevant container
        splSTATSSkills.Visible = True
        ' hide the remaining containers of this group
        splSTATSStatus.Visible = False
        splSTATSSpecial.Visible = False
        splSTATSPerks.Visible = False
        splSTATSGeneral.Visible = False
        ' enable the relevant buttons
        btnSTATSSkillsBarter.Enabled = True
        btnSTATSSkillsEnergyWeapons.Enabled = True
        btnSTATSSkillsExplosives.Enabled = True
        btnSTATSSkillsGuns.Enabled = True
        btnSTATSSkillsLockpick.Enabled = True
        btnSTATSSkillsMedicine.Enabled = True
        btnSTATSSkillsMeleeWeapons.Enabled = True
        btnSTATSSkillsRepair.Enabled = True
        btnSTATSSkillsScience.Enabled = True
        btnSTATSSkillsSneak.Enabled = True
        btnSTATSSkillsSpeech.Enabled = True
        btnSTATSSkillsSurvival.Enabled = True
        btnSTATSSkillsUnarmed.Enabled = True
        ' hide all relevant labels
        lblSTATSSkillsBarter.Visible = False
        lblSTATSSkillsEnergyWeapons.Visible = False
        lblSTATSSkillsExplosives.Visible = False
        lblSTATSSkillsGuns.Visible = False
        lblSTATSSkillsLockpick.Visible = False
        lblSTATSSkillsMedicine.Visible = False
        lblSTATSSkillsMeleeWeapons.Visible = False
        lblSTATSSkillsRepair.Visible = False
        lblSTATSSkillsScience.Visible = False
        lblSTATSSkillsSneak.Visible = False
        lblSTATSSkillsSpeech.Visible = False
        lblSTATSSkillsSurvival.Visible = False
        lblSTATSSkillsUnarmed.Visible = False
    End Sub

    Private Sub btnSTATSSkillsBarter_Click(sender As Object, e As EventArgs) Handles btnSTATSSkillsBarter.Click
        ' disable the button clicked
        btnSTATSSkillsBarter.Enabled = False
        ' enable the other buttons
        btnSTATSSkillsEnergyWeapons.Enabled = True
        btnSTATSSkillsExplosives.Enabled = True
        btnSTATSSkillsGuns.Enabled = True
        btnSTATSSkillsLockpick.Enabled = True
        btnSTATSSkillsMedicine.Enabled = True
        btnSTATSSkillsMeleeWeapons.Enabled = True
        btnSTATSSkillsRepair.Enabled = True
        btnSTATSSkillsScience.Enabled = True
        btnSTATSSkillsSneak.Enabled = True
        btnSTATSSkillsSpeech.Enabled = True
        btnSTATSSkillsSurvival.Enabled = True
        btnSTATSSkillsUnarmed.Enabled = True
        ' display the relevant label
        lblSTATSSkillsBarter.Visible = True
        ' hide the remaining labels within the container
        lblSTATSSkillsEnergyWeapons.Visible = False
        lblSTATSSkillsExplosives.Visible = False
        lblSTATSSkillsGuns.Visible = False
        lblSTATSSkillsLockpick.Visible = False
        lblSTATSSkillsMedicine.Visible = False
        lblSTATSSkillsMeleeWeapons.Visible = False
        lblSTATSSkillsRepair.Visible = False
        lblSTATSSkillsScience.Visible = False
        lblSTATSSkillsSneak.Visible = False
        lblSTATSSkillsSpeech.Visible = False
        lblSTATSSkillsSurvival.Visible = False
        lblSTATSSkillsUnarmed.Visible = False
    End Sub

    Private Sub btnSTATSSkillsEnergyWeapons_Click(sender As Object, e As EventArgs) Handles btnSTATSSkillsEnergyWeapons.Click
        ' disable the button clicked
        btnSTATSSkillsEnergyWeapons.Enabled = False
        ' enable the other buttons
        btnSTATSSkillsBarter.Enabled = True
        btnSTATSSkillsExplosives.Enabled = True
        btnSTATSSkillsGuns.Enabled = True
        btnSTATSSkillsLockpick.Enabled = True
        btnSTATSSkillsMedicine.Enabled = True
        btnSTATSSkillsMeleeWeapons.Enabled = True
        btnSTATSSkillsRepair.Enabled = True
        btnSTATSSkillsScience.Enabled = True
        btnSTATSSkillsSneak.Enabled = True
        btnSTATSSkillsSpeech.Enabled = True
        btnSTATSSkillsSurvival.Enabled = True
        btnSTATSSkillsUnarmed.Enabled = True
        ' display the relevant label
        lblSTATSSkillsEnergyWeapons.Visible = True
        ' hide the remaining labels within the container
        lblSTATSSkillsBarter.Visible = False
        lblSTATSSkillsExplosives.Visible = False
        lblSTATSSkillsGuns.Visible = False
        lblSTATSSkillsLockpick.Visible = False
        lblSTATSSkillsMedicine.Visible = False
        lblSTATSSkillsMeleeWeapons.Visible = False
        lblSTATSSkillsRepair.Visible = False
        lblSTATSSkillsScience.Visible = False
        lblSTATSSkillsSneak.Visible = False
        lblSTATSSkillsSpeech.Visible = False
        lblSTATSSkillsSurvival.Visible = False
        lblSTATSSkillsUnarmed.Visible = False
    End Sub

    Private Sub btnSTATSSkillsExplosives_Click(sender As Object, e As EventArgs) Handles btnSTATSSkillsExplosives.Click
        ' disable the button clicked
        btnSTATSSkillsExplosives.Enabled = False
        ' enable the other buttons
        btnSTATSSkillsBarter.Enabled = True
        btnSTATSSkillsEnergyWeapons.Enabled = True
        btnSTATSSkillsGuns.Enabled = True
        btnSTATSSkillsLockpick.Enabled = True
        btnSTATSSkillsMedicine.Enabled = True
        btnSTATSSkillsMeleeWeapons.Enabled = True
        btnSTATSSkillsRepair.Enabled = True
        btnSTATSSkillsScience.Enabled = True
        btnSTATSSkillsSneak.Enabled = True
        btnSTATSSkillsSpeech.Enabled = True
        btnSTATSSkillsSurvival.Enabled = True
        btnSTATSSkillsUnarmed.Enabled = True
        ' display the relevant label
        lblSTATSSkillsExplosives.Visible = True
        ' hide the remaining labels within the container
        lblSTATSSkillsBarter.Visible = False
        lblSTATSSkillsEnergyWeapons.Visible = False
        lblSTATSSkillsGuns.Visible = False
        lblSTATSSkillsLockpick.Visible = False
        lblSTATSSkillsMedicine.Visible = False
        lblSTATSSkillsMeleeWeapons.Visible = False
        lblSTATSSkillsRepair.Visible = False
        lblSTATSSkillsScience.Visible = False
        lblSTATSSkillsSneak.Visible = False
        lblSTATSSkillsSpeech.Visible = False
        lblSTATSSkillsSurvival.Visible = False
        lblSTATSSkillsUnarmed.Visible = False
    End Sub

    Private Sub btnSTATSSkillsGuns_Click(sender As Object, e As EventArgs) Handles btnSTATSSkillsGuns.Click
        ' disable the button clicked
        btnSTATSSkillsGuns.Enabled = False
        ' enable the other buttons
        btnSTATSSkillsBarter.Enabled = True
        btnSTATSSkillsEnergyWeapons.Enabled = True
        btnSTATSSkillsExplosives.Enabled = True
        btnSTATSSkillsLockpick.Enabled = True
        btnSTATSSkillsMedicine.Enabled = True
        btnSTATSSkillsMeleeWeapons.Enabled = True
        btnSTATSSkillsRepair.Enabled = True
        btnSTATSSkillsScience.Enabled = True
        btnSTATSSkillsSneak.Enabled = True
        btnSTATSSkillsSpeech.Enabled = True
        btnSTATSSkillsSurvival.Enabled = True
        btnSTATSSkillsUnarmed.Enabled = True
        ' display the relevant label
        lblSTATSSkillsGuns.Visible = True
        ' hide the remaining labels within the container
        lblSTATSSkillsBarter.Visible = False
        lblSTATSSkillsEnergyWeapons.Visible = False
        lblSTATSSkillsExplosives.Visible = False
        lblSTATSSkillsLockpick.Visible = False
        lblSTATSSkillsMedicine.Visible = False
        lblSTATSSkillsMeleeWeapons.Visible = False
        lblSTATSSkillsRepair.Visible = False
        lblSTATSSkillsScience.Visible = False
        lblSTATSSkillsSneak.Visible = False
        lblSTATSSkillsSpeech.Visible = False
        lblSTATSSkillsSurvival.Visible = False
        lblSTATSSkillsUnarmed.Visible = False
    End Sub

    Private Sub btnSTATSSkillsLockpick_Click(sender As Object, e As EventArgs) Handles btnSTATSSkillsLockpick.Click
        ' disable the button clicked
        btnSTATSSkillsLockpick.Enabled = False
        ' enable the other buttons
        btnSTATSSkillsBarter.Enabled = True
        btnSTATSSkillsEnergyWeapons.Enabled = True
        btnSTATSSkillsExplosives.Enabled = True
        btnSTATSSkillsGuns.Enabled = True
        btnSTATSSkillsMedicine.Enabled = True
        btnSTATSSkillsMeleeWeapons.Enabled = True
        btnSTATSSkillsRepair.Enabled = True
        btnSTATSSkillsScience.Enabled = True
        btnSTATSSkillsSneak.Enabled = True
        btnSTATSSkillsSpeech.Enabled = True
        btnSTATSSkillsSurvival.Enabled = True
        btnSTATSSkillsUnarmed.Enabled = True
        ' display the relevant label
        lblSTATSSkillsLockpick.Visible = True
        ' hide the remaining labels within the container
        lblSTATSSkillsBarter.Visible = False
        lblSTATSSkillsEnergyWeapons.Visible = False
        lblSTATSSkillsExplosives.Visible = False
        lblSTATSSkillsGuns.Visible = False
        lblSTATSSkillsMedicine.Visible = False
        lblSTATSSkillsMeleeWeapons.Visible = False
        lblSTATSSkillsRepair.Visible = False
        lblSTATSSkillsScience.Visible = False
        lblSTATSSkillsSneak.Visible = False
        lblSTATSSkillsSpeech.Visible = False
        lblSTATSSkillsSurvival.Visible = False
        lblSTATSSkillsUnarmed.Visible = False
    End Sub

    Private Sub btnSTATSSkillsMedicine_Click(sender As Object, e As EventArgs) Handles btnSTATSSkillsMedicine.Click
        ' disable the button clicked
        btnSTATSSkillsMedicine.Enabled = False
        ' enable the other buttons
        btnSTATSSkillsBarter.Enabled = True
        btnSTATSSkillsEnergyWeapons.Enabled = True
        btnSTATSSkillsExplosives.Enabled = True
        btnSTATSSkillsGuns.Enabled = True
        btnSTATSSkillsLockpick.Enabled = True
        btnSTATSSkillsMeleeWeapons.Enabled = True
        btnSTATSSkillsRepair.Enabled = True
        btnSTATSSkillsScience.Enabled = True
        btnSTATSSkillsSneak.Enabled = True
        btnSTATSSkillsSpeech.Enabled = True
        btnSTATSSkillsSurvival.Enabled = True
        btnSTATSSkillsUnarmed.Enabled = True
        ' display the relevant label
        lblSTATSSkillsMedicine.Visible = True
        ' hide the remaining labels within the container
        lblSTATSSkillsBarter.Visible = False
        lblSTATSSkillsEnergyWeapons.Visible = False
        lblSTATSSkillsExplosives.Visible = False
        lblSTATSSkillsGuns.Visible = False
        lblSTATSSkillsLockpick.Visible = False
        lblSTATSSkillsMeleeWeapons.Visible = False
        lblSTATSSkillsRepair.Visible = False
        lblSTATSSkillsScience.Visible = False
        lblSTATSSkillsSneak.Visible = False
        lblSTATSSkillsSpeech.Visible = False
        lblSTATSSkillsSurvival.Visible = False
        lblSTATSSkillsUnarmed.Visible = False
    End Sub

    Private Sub btnSTATSSkillsMeleeWeapons_Click(sender As Object, e As EventArgs) Handles btnSTATSSkillsMeleeWeapons.Click
        ' disable the button clicked
        btnSTATSSkillsMeleeWeapons.Enabled = False
        ' enable the other buttons
        btnSTATSSkillsBarter.Enabled = True
        btnSTATSSkillsEnergyWeapons.Enabled = True
        btnSTATSSkillsExplosives.Enabled = True
        btnSTATSSkillsGuns.Enabled = True
        btnSTATSSkillsLockpick.Enabled = True
        btnSTATSSkillsMedicine.Enabled = True
        btnSTATSSkillsRepair.Enabled = True
        btnSTATSSkillsScience.Enabled = True
        btnSTATSSkillsSneak.Enabled = True
        btnSTATSSkillsSpeech.Enabled = True
        btnSTATSSkillsSurvival.Enabled = True
        btnSTATSSkillsUnarmed.Enabled = True
        ' display the relevant label
        lblSTATSSkillsMeleeWeapons.Visible = True
        ' hide the remaining labels within the container
        lblSTATSSkillsBarter.Visible = False
        lblSTATSSkillsEnergyWeapons.Visible = False
        lblSTATSSkillsExplosives.Visible = False
        lblSTATSSkillsGuns.Visible = False
        lblSTATSSkillsLockpick.Visible = False
        lblSTATSSkillsMedicine.Visible = False
        lblSTATSSkillsRepair.Visible = False
        lblSTATSSkillsScience.Visible = False
        lblSTATSSkillsSneak.Visible = False
        lblSTATSSkillsSpeech.Visible = False
        lblSTATSSkillsSurvival.Visible = False
        lblSTATSSkillsUnarmed.Visible = False
    End Sub

    Private Sub btnSTATSSkillsRepair_Click(sender As Object, e As EventArgs) Handles btnSTATSSkillsRepair.Click
        ' disable the button clicked
        btnSTATSSkillsRepair.Enabled = False
        ' enable the other buttons
        btnSTATSSkillsBarter.Enabled = True
        btnSTATSSkillsEnergyWeapons.Enabled = True
        btnSTATSSkillsExplosives.Enabled = True
        btnSTATSSkillsGuns.Enabled = True
        btnSTATSSkillsLockpick.Enabled = True
        btnSTATSSkillsMedicine.Enabled = True
        btnSTATSSkillsMeleeWeapons.Enabled = True
        btnSTATSSkillsScience.Enabled = True
        btnSTATSSkillsSneak.Enabled = True
        btnSTATSSkillsSpeech.Enabled = True
        btnSTATSSkillsSurvival.Enabled = True
        btnSTATSSkillsUnarmed.Enabled = True
        ' display the relevant label
        lblSTATSSkillsRepair.Visible = True
        ' hide the remaining labels within the container
        lblSTATSSkillsBarter.Visible = False
        lblSTATSSkillsEnergyWeapons.Visible = False
        lblSTATSSkillsExplosives.Visible = False
        lblSTATSSkillsGuns.Visible = False
        lblSTATSSkillsLockpick.Visible = False
        lblSTATSSkillsMedicine.Visible = False
        lblSTATSSkillsMeleeWeapons.Visible = False
        lblSTATSSkillsScience.Visible = False
        lblSTATSSkillsSneak.Visible = False
        lblSTATSSkillsSpeech.Visible = False
        lblSTATSSkillsSurvival.Visible = False
        lblSTATSSkillsUnarmed.Visible = False
    End Sub

    Private Sub btnSTATSSkillsScience_Click(sender As Object, e As EventArgs) Handles btnSTATSSkillsScience.Click
        ' disable the button clicked
        btnSTATSSkillsScience.Enabled = False
        ' enable the other buttons
        btnSTATSSkillsBarter.Enabled = True
        btnSTATSSkillsEnergyWeapons.Enabled = True
        btnSTATSSkillsExplosives.Enabled = True
        btnSTATSSkillsGuns.Enabled = True
        btnSTATSSkillsLockpick.Enabled = True
        btnSTATSSkillsMedicine.Enabled = True
        btnSTATSSkillsMeleeWeapons.Enabled = True
        btnSTATSSkillsRepair.Enabled = True
        btnSTATSSkillsSneak.Enabled = True
        btnSTATSSkillsSpeech.Enabled = True
        btnSTATSSkillsSurvival.Enabled = True
        btnSTATSSkillsUnarmed.Enabled = True
        ' display the relevant label
        lblSTATSSkillsScience.Visible = True
        ' hide the remaining labels within the container
        lblSTATSSkillsBarter.Visible = False
        lblSTATSSkillsEnergyWeapons.Visible = False
        lblSTATSSkillsExplosives.Visible = False
        lblSTATSSkillsGuns.Visible = False
        lblSTATSSkillsLockpick.Visible = False
        lblSTATSSkillsMedicine.Visible = False
        lblSTATSSkillsMeleeWeapons.Visible = False
        lblSTATSSkillsRepair.Visible = False
        lblSTATSSkillsSneak.Visible = False
        lblSTATSSkillsSpeech.Visible = False
        lblSTATSSkillsSurvival.Visible = False
        lblSTATSSkillsUnarmed.Visible = False
    End Sub

    Private Sub btnSTATSSkillsSneak_Click(sender As Object, e As EventArgs) Handles btnSTATSSkillsSneak.Click
        ' disable the button clicked
        btnSTATSSkillsSneak.Enabled = False
        ' enable the other buttons
        btnSTATSSkillsBarter.Enabled = True
        btnSTATSSkillsEnergyWeapons.Enabled = True
        btnSTATSSkillsExplosives.Enabled = True
        btnSTATSSkillsGuns.Enabled = True
        btnSTATSSkillsLockpick.Enabled = True
        btnSTATSSkillsMedicine.Enabled = True
        btnSTATSSkillsMeleeWeapons.Enabled = True
        btnSTATSSkillsRepair.Enabled = True
        btnSTATSSkillsScience.Enabled = True
        btnSTATSSkillsSpeech.Enabled = True
        btnSTATSSkillsSurvival.Enabled = True
        btnSTATSSkillsUnarmed.Enabled = True
        ' display the relevant label
        lblSTATSSkillsSneak.Visible = True
        ' hide the remaining labels within the container
        lblSTATSSkillsBarter.Visible = False
        lblSTATSSkillsEnergyWeapons.Visible = False
        lblSTATSSkillsExplosives.Visible = False
        lblSTATSSkillsGuns.Visible = False
        lblSTATSSkillsLockpick.Visible = False
        lblSTATSSkillsMedicine.Visible = False
        lblSTATSSkillsMeleeWeapons.Visible = False
        lblSTATSSkillsRepair.Visible = False
        lblSTATSSkillsScience.Visible = False
        lblSTATSSkillsSpeech.Visible = False
        lblSTATSSkillsSurvival.Visible = False
        lblSTATSSkillsUnarmed.Visible = False
    End Sub

    Private Sub btnSTATSSkillsSpeech_Click(sender As Object, e As EventArgs) Handles btnSTATSSkillsSpeech.Click
        ' disable the button clicked
        btnSTATSSkillsSpeech.Enabled = False
        ' enable the other buttons
        btnSTATSSkillsBarter.Enabled = True
        btnSTATSSkillsEnergyWeapons.Enabled = True
        btnSTATSSkillsExplosives.Enabled = True
        btnSTATSSkillsGuns.Enabled = True
        btnSTATSSkillsLockpick.Enabled = True
        btnSTATSSkillsMedicine.Enabled = True
        btnSTATSSkillsMeleeWeapons.Enabled = True
        btnSTATSSkillsRepair.Enabled = True
        btnSTATSSkillsScience.Enabled = True
        btnSTATSSkillsSneak.Enabled = True
        btnSTATSSkillsSurvival.Enabled = True
        btnSTATSSkillsUnarmed.Enabled = True
        ' display the relevant label
        lblSTATSSkillsSpeech.Visible = True
        ' hide the remaining labels within the container
        lblSTATSSkillsBarter.Visible = False
        lblSTATSSkillsEnergyWeapons.Visible = False
        lblSTATSSkillsExplosives.Visible = False
        lblSTATSSkillsGuns.Visible = False
        lblSTATSSkillsLockpick.Visible = False
        lblSTATSSkillsMedicine.Visible = False
        lblSTATSSkillsMeleeWeapons.Visible = False
        lblSTATSSkillsRepair.Visible = False
        lblSTATSSkillsScience.Visible = False
        lblSTATSSkillsSneak.Visible = False
        lblSTATSSkillsSurvival.Visible = False
        lblSTATSSkillsUnarmed.Visible = False
    End Sub

    Private Sub btnSTATSSkillsSurvival_Click(sender As Object, e As EventArgs) Handles btnSTATSSkillsSurvival.Click
        ' disable the button clicked
        btnSTATSSkillsSurvival.Enabled = False
        ' enable the other buttons
        btnSTATSSkillsBarter.Enabled = True
        btnSTATSSkillsEnergyWeapons.Enabled = True
        btnSTATSSkillsExplosives.Enabled = True
        btnSTATSSkillsGuns.Enabled = True
        btnSTATSSkillsLockpick.Enabled = True
        btnSTATSSkillsMedicine.Enabled = True
        btnSTATSSkillsMeleeWeapons.Enabled = True
        btnSTATSSkillsRepair.Enabled = True
        btnSTATSSkillsScience.Enabled = True
        btnSTATSSkillsSneak.Enabled = True
        btnSTATSSkillsSpeech.Enabled = True
        btnSTATSSkillsUnarmed.Enabled = True
        ' display the relevant label
        lblSTATSSkillsSurvival.Visible = True
        ' hide the remaining labels within the container
        lblSTATSSkillsBarter.Visible = False
        lblSTATSSkillsEnergyWeapons.Visible = False
        lblSTATSSkillsExplosives.Visible = False
        lblSTATSSkillsGuns.Visible = False
        lblSTATSSkillsLockpick.Visible = False
        lblSTATSSkillsMedicine.Visible = False
        lblSTATSSkillsMeleeWeapons.Visible = False
        lblSTATSSkillsRepair.Visible = False
        lblSTATSSkillsScience.Visible = False
        lblSTATSSkillsSneak.Visible = False
        lblSTATSSkillsSpeech.Visible = False
        lblSTATSSkillsUnarmed.Visible = False
    End Sub

    Private Sub btnSTATSSkillsUnarmed_Click(sender As Object, e As EventArgs) Handles btnSTATSSkillsUnarmed.Click
        ' disable the button clicked
        btnSTATSSkillsUnarmed.Enabled = False
        ' enable the other buttons
        btnSTATSSkillsBarter.Enabled = True
        btnSTATSSkillsEnergyWeapons.Enabled = True
        btnSTATSSkillsExplosives.Enabled = True
        btnSTATSSkillsGuns.Enabled = True
        btnSTATSSkillsLockpick.Enabled = True
        btnSTATSSkillsMedicine.Enabled = True
        btnSTATSSkillsMeleeWeapons.Enabled = True
        btnSTATSSkillsRepair.Enabled = True
        btnSTATSSkillsScience.Enabled = True
        btnSTATSSkillsSneak.Enabled = True
        btnSTATSSkillsSpeech.Enabled = True
        btnSTATSSkillsSurvival.Enabled = True
        ' display the relevant label
        lblSTATSSkillsUnarmed.Visible = True
        ' hide the remaining labels within the container
        lblSTATSSkillsBarter.Visible = False
        lblSTATSSkillsEnergyWeapons.Visible = False
        lblSTATSSkillsExplosives.Visible = False
        lblSTATSSkillsGuns.Visible = False
        lblSTATSSkillsLockpick.Visible = False
        lblSTATSSkillsMedicine.Visible = False
        lblSTATSSkillsMeleeWeapons.Visible = False
        lblSTATSSkillsRepair.Visible = False
        lblSTATSSkillsScience.Visible = False
        lblSTATSSkillsSneak.Visible = False
        lblSTATSSkillsSpeech.Visible = False
        lblSTATSSkillsSurvival.Visible = False
    End Sub

    Private Sub btnSTATSPerks_Click(sender As Object, e As EventArgs) Handles btnSTATSPerks.Click
        ' disable the button clicked
        btnSTATSPerks.Enabled = False
        ' enable the other buttons
        btnSTATSStatus.Enabled = True
        btnSTATSSpecial.Enabled = True
        btnSTATSSkills.Enabled = True
        btnSTATSGeneral.Enabled = True
        ' display the relevant container
        splSTATSPerks.Visible = True
        ' hide the remaining containers of this group
        splSTATSSkills.Visible = False
        splSTATSSpecial.Visible = False
        splSTATSSkills.Visible = False
        splSTATSGeneral.Visible = False
        ' display the relevant label
        lblSTATSPerks.Visible = True
    End Sub

    Private Sub btnSTATSGeneral_Click(sender As Object, e As EventArgs) Handles btnSTATSGeneral.Click
        ' disable the button clicked
        btnSTATSGeneral.Enabled = False
        ' enable the other buttons
        btnSTATSStatus.Enabled = True
        btnSTATSSpecial.Enabled = True
        btnSTATSSkills.Enabled = True
        btnSTATSPerks.Enabled = True
        ' display the relevant container
        splSTATSGeneral.Visible = True
        ' hide the remaining containers of this group
        splSTATSStatus.Visible = False
        splSTATSSpecial.Visible = False
        splSTATSSkills.Visible = False
        splSTATSPerks.Visible = False
        ' enable the relevant buttons
        btnSTATSGeneralBoomers.Enabled = True
        btnSTATSGeneralBrotherhood.Enabled = True
        btnSTATSGeneralLegion.Enabled = True
        btnSTATSGeneralFollowers.Enabled = True
        btnSTATSGeneralFreeside.Enabled = True
        btnSTATSGeneralGoodsprings.Enabled = True
        btnSTATSGeneralGreatKhans.Enabled = True
        btnSTATSGeneralNCR.Enabled = True
        btnSTATSGeneralNovac.Enabled = True
        btnSTATSGeneralPowderGangers.Enabled = True
        btnSTATSGeneralPrimm.Enabled = True
        btnSTATSGeneralStrip.Enabled = True
        btnSTATSGeneralWhiteGlove.Enabled = True
        ' hide all relevant labels
        lblSTATSGeneralBoomers.Visible = False
        lblSTATSGeneralBrotherhood.Visible = False
        lblSTATSGeneralLegion.Visible = False
        lblSTATSGeneralFollowers.Visible = False
        lblSTATSGeneralFreeside.Visible = False
        lblSTATSGeneralGoodsprings.Visible = False
        lblSTATSGeneralGreatKhans.Visible = False
        lblSTATSGeneralNCR.Visible = False
        lblSTATSGeneralNovac.Visible = False
        lblSTATSGeneralPowderGangers.Visible = False
        lblSTATSGeneralPrimm.Visible = False
        lblSTATSGeneralStrip.Visible = False
        lblSTATSGeneralWhiteGlove.Visible = False
    End Sub

    Private Sub btnSTATSGeneralBoomers_Click(sender As Object, e As EventArgs) Handles btnSTATSGeneralBoomers.Click
        ' disable the button clicked
        btnSTATSGeneralBoomers.Enabled = False
        ' enable the other buttons
        btnSTATSGeneralBrotherhood.Enabled = True
        btnSTATSGeneralLegion.Enabled = True
        btnSTATSGeneralFollowers.Enabled = True
        btnSTATSGeneralFreeside.Enabled = True
        btnSTATSGeneralGoodsprings.Enabled = True
        btnSTATSGeneralGreatKhans.Enabled = True
        btnSTATSGeneralNCR.Enabled = True
        btnSTATSGeneralNovac.Enabled = True
        btnSTATSGeneralPowderGangers.Enabled = True
        btnSTATSGeneralPrimm.Enabled = True
        btnSTATSGeneralStrip.Enabled = True
        btnSTATSGeneralWhiteGlove.Enabled = True
        ' display the relevant label
        lblSTATSGeneralBoomers.Visible = True
        ' hide the remaining labels within the container
        lblSTATSGeneralBrotherhood.Visible = False
        lblSTATSGeneralLegion.Visible = False
        lblSTATSGeneralFollowers.Visible = False
        lblSTATSGeneralFreeside.Visible = False
        lblSTATSGeneralGoodsprings.Visible = False
        lblSTATSGeneralGreatKhans.Visible = False
        lblSTATSGeneralNCR.Visible = False
        lblSTATSGeneralNovac.Visible = False
        lblSTATSGeneralPowderGangers.Visible = False
        lblSTATSGeneralPrimm.Visible = False
        lblSTATSGeneralStrip.Visible = False
        lblSTATSGeneralWhiteGlove.Visible = False
    End Sub

    Private Sub btnSTATSGeneralBrotherhood_Click(sender As Object, e As EventArgs) Handles btnSTATSGeneralBrotherhood.Click
        ' disable the button clicked
        btnSTATSGeneralBrotherhood.Enabled = False
        ' enable the other buttons
        btnSTATSGeneralBoomers.Enabled = True
        btnSTATSGeneralLegion.Enabled = True
        btnSTATSGeneralFollowers.Enabled = True
        btnSTATSGeneralFreeside.Enabled = True
        btnSTATSGeneralGoodsprings.Enabled = True
        btnSTATSGeneralGreatKhans.Enabled = True
        btnSTATSGeneralNCR.Enabled = True
        btnSTATSGeneralNovac.Enabled = True
        btnSTATSGeneralPowderGangers.Enabled = True
        btnSTATSGeneralPrimm.Enabled = True
        btnSTATSGeneralStrip.Enabled = True
        btnSTATSGeneralWhiteGlove.Enabled = True
        ' display the relevant label
        lblSTATSGeneralBrotherhood.Visible = True
        ' hide the remaining labels within the container
        lblSTATSGeneralBoomers.Visible = False
        lblSTATSGeneralLegion.Visible = False
        lblSTATSGeneralFollowers.Visible = False
        lblSTATSGeneralFreeside.Visible = False
        lblSTATSGeneralGoodsprings.Visible = False
        lblSTATSGeneralGreatKhans.Visible = False
        lblSTATSGeneralNCR.Visible = False
        lblSTATSGeneralNovac.Visible = False
        lblSTATSGeneralPowderGangers.Visible = False
        lblSTATSGeneralPrimm.Visible = False
        lblSTATSGeneralStrip.Visible = False
        lblSTATSGeneralWhiteGlove.Visible = False
    End Sub

    Private Sub btnSTATSGeneralLegion_Click(sender As Object, e As EventArgs) Handles btnSTATSGeneralLegion.Click
        ' disable the button clicked
        btnSTATSGeneralLegion.Enabled = False
        ' enable the other buttons
        btnSTATSGeneralBoomers.Enabled = True
        btnSTATSGeneralBrotherhood.Enabled = True
        btnSTATSGeneralFollowers.Enabled = True
        btnSTATSGeneralFreeside.Enabled = True
        btnSTATSGeneralGoodsprings.Enabled = True
        btnSTATSGeneralGreatKhans.Enabled = True
        btnSTATSGeneralNCR.Enabled = True
        btnSTATSGeneralNovac.Enabled = True
        btnSTATSGeneralPowderGangers.Enabled = True
        btnSTATSGeneralPrimm.Enabled = True
        btnSTATSGeneralStrip.Enabled = True
        btnSTATSGeneralWhiteGlove.Enabled = True
        ' display the relevant label
        lblSTATSGeneralLegion.Visible = True
        ' hide the remaining labels within the container
        lblSTATSGeneralBoomers.Visible = False
        lblSTATSGeneralBrotherhood.Visible = False
        lblSTATSGeneralFollowers.Visible = False
        lblSTATSGeneralFreeside.Visible = False
        lblSTATSGeneralGoodsprings.Visible = False
        lblSTATSGeneralGreatKhans.Visible = False
        lblSTATSGeneralNCR.Visible = False
        lblSTATSGeneralNovac.Visible = False
        lblSTATSGeneralPowderGangers.Visible = False
        lblSTATSGeneralPrimm.Visible = False
        lblSTATSGeneralStrip.Visible = False
        lblSTATSGeneralWhiteGlove.Visible = False
    End Sub

    Private Sub btnSTATSGeneralFollowers_Click(sender As Object, e As EventArgs) Handles btnSTATSGeneralFollowers.Click
        ' disable the button clicked
        btnSTATSGeneralFollowers.Enabled = False
        ' enable the other buttons
        btnSTATSGeneralBoomers.Enabled = True
        btnSTATSGeneralBrotherhood.Enabled = True
        btnSTATSGeneralLegion.Enabled = True
        btnSTATSGeneralFreeside.Enabled = True
        btnSTATSGeneralGoodsprings.Enabled = True
        btnSTATSGeneralGreatKhans.Enabled = True
        btnSTATSGeneralNCR.Enabled = True
        btnSTATSGeneralNovac.Enabled = True
        btnSTATSGeneralPowderGangers.Enabled = True
        btnSTATSGeneralPrimm.Enabled = True
        btnSTATSGeneralStrip.Enabled = True
        btnSTATSGeneralWhiteGlove.Enabled = True
        ' display the relevant label
        lblSTATSGeneralFollowers.Visible = True
        ' hide the remaining labels within the container
        lblSTATSGeneralBoomers.Visible = False
        lblSTATSGeneralBrotherhood.Visible = False
        lblSTATSGeneralLegion.Visible = False
        lblSTATSGeneralFreeside.Visible = False
        lblSTATSGeneralGoodsprings.Visible = False
        lblSTATSGeneralGreatKhans.Visible = False
        lblSTATSGeneralNCR.Visible = False
        lblSTATSGeneralNovac.Visible = False
        lblSTATSGeneralPowderGangers.Visible = False
        lblSTATSGeneralPrimm.Visible = False
        lblSTATSGeneralStrip.Visible = False
        lblSTATSGeneralWhiteGlove.Visible = False
    End Sub

    Private Sub btnSTATSGeneralFreeside_Click(sender As Object, e As EventArgs) Handles btnSTATSGeneralFreeside.Click
        ' disable the button clicked
        btnSTATSGeneralFreeside.Enabled = False
        ' enable the other buttons
        btnSTATSGeneralBoomers.Enabled = True
        btnSTATSGeneralBrotherhood.Enabled = True
        btnSTATSGeneralLegion.Enabled = True
        btnSTATSGeneralFollowers.Enabled = True
        btnSTATSGeneralGoodsprings.Enabled = True
        btnSTATSGeneralGreatKhans.Enabled = True
        btnSTATSGeneralNCR.Enabled = True
        btnSTATSGeneralNovac.Enabled = True
        btnSTATSGeneralPowderGangers.Enabled = True
        btnSTATSGeneralPrimm.Enabled = True
        btnSTATSGeneralStrip.Enabled = True
        btnSTATSGeneralWhiteGlove.Enabled = True
        ' display the relevant label
        lblSTATSGeneralFreeside.Visible = True
        ' hide the remaining labels within the container
        lblSTATSGeneralBoomers.Visible = False
        lblSTATSGeneralBrotherhood.Visible = False
        lblSTATSGeneralLegion.Visible = False
        lblSTATSGeneralFollowers.Visible = False
        lblSTATSGeneralGoodsprings.Visible = False
        lblSTATSGeneralGreatKhans.Visible = False
        lblSTATSGeneralNCR.Visible = False
        lblSTATSGeneralNovac.Visible = False
        lblSTATSGeneralPowderGangers.Visible = False
        lblSTATSGeneralPrimm.Visible = False
        lblSTATSGeneralStrip.Visible = False
        lblSTATSGeneralWhiteGlove.Visible = False
    End Sub

    Private Sub btnSTATSGeneralGoodsprings_Click(sender As Object, e As EventArgs) Handles btnSTATSGeneralGoodsprings.Click
        ' disable the button clicked
        btnSTATSGeneralGoodsprings.Enabled = False
        ' enable the other buttons
        btnSTATSGeneralBoomers.Enabled = True
        btnSTATSGeneralBrotherhood.Enabled = True
        btnSTATSGeneralLegion.Enabled = True
        btnSTATSGeneralFollowers.Enabled = True
        btnSTATSGeneralFreeside.Enabled = True
        btnSTATSGeneralGreatKhans.Enabled = True
        btnSTATSGeneralNCR.Enabled = True
        btnSTATSGeneralNovac.Enabled = True
        btnSTATSGeneralPowderGangers.Enabled = True
        btnSTATSGeneralPrimm.Enabled = True
        btnSTATSGeneralStrip.Enabled = True
        btnSTATSGeneralWhiteGlove.Enabled = True
        ' display the relevant label
        lblSTATSGeneralGoodsprings.Visible = True
        ' hide the remaining labels within the container
        lblSTATSGeneralBoomers.Visible = False
        lblSTATSGeneralBrotherhood.Visible = False
        lblSTATSGeneralLegion.Visible = False
        lblSTATSGeneralFollowers.Visible = False
        lblSTATSGeneralFreeside.Visible = False
        lblSTATSGeneralGreatKhans.Visible = False
        lblSTATSGeneralNCR.Visible = False
        lblSTATSGeneralNovac.Visible = False
        lblSTATSGeneralPowderGangers.Visible = False
        lblSTATSGeneralPrimm.Visible = False
        lblSTATSGeneralStrip.Visible = False
        lblSTATSGeneralWhiteGlove.Visible = False
    End Sub

    Private Sub btnSTATSGeneralGreatKhans_Click(sender As Object, e As EventArgs) Handles btnSTATSGeneralGreatKhans.Click
        ' disable the button clicked
        btnSTATSGeneralGreatKhans.Enabled = False
        ' enable the other buttons
        btnSTATSGeneralBoomers.Enabled = True
        btnSTATSGeneralBrotherhood.Enabled = True
        btnSTATSGeneralLegion.Enabled = True
        btnSTATSGeneralFollowers.Enabled = True
        btnSTATSGeneralFreeside.Enabled = True
        btnSTATSGeneralGoodsprings.Enabled = True
        btnSTATSGeneralNCR.Enabled = True
        btnSTATSGeneralNovac.Enabled = True
        btnSTATSGeneralPowderGangers.Enabled = True
        btnSTATSGeneralPrimm.Enabled = True
        btnSTATSGeneralStrip.Enabled = True
        btnSTATSGeneralWhiteGlove.Enabled = True
        ' display the relevant label
        lblSTATSGeneralGreatKhans.Visible = True
        ' hide the remaining labels within the container
        lblSTATSGeneralBoomers.Visible = False
        lblSTATSGeneralBrotherhood.Visible = False
        lblSTATSGeneralLegion.Visible = False
        lblSTATSGeneralFollowers.Visible = False
        lblSTATSGeneralFreeside.Visible = False
        lblSTATSGeneralGoodsprings.Visible = False
        lblSTATSGeneralNCR.Visible = False
        lblSTATSGeneralNovac.Visible = False
        lblSTATSGeneralPowderGangers.Visible = False
        lblSTATSGeneralPrimm.Visible = False
        lblSTATSGeneralStrip.Visible = False
        lblSTATSGeneralWhiteGlove.Visible = False
    End Sub

    Private Sub btnSTATSGeneralNCR_Click(sender As Object, e As EventArgs) Handles btnSTATSGeneralNCR.Click
        ' disable the button clicked
        btnSTATSGeneralNCR.Enabled = False
        ' enable the other buttons
        btnSTATSGeneralBoomers.Enabled = True
        btnSTATSGeneralBrotherhood.Enabled = True
        btnSTATSGeneralLegion.Enabled = True
        btnSTATSGeneralFollowers.Enabled = True
        btnSTATSGeneralFreeside.Enabled = True
        btnSTATSGeneralGoodsprings.Enabled = True
        btnSTATSGeneralGreatKhans.Enabled = True
        btnSTATSGeneralNovac.Enabled = True
        btnSTATSGeneralPowderGangers.Enabled = True
        btnSTATSGeneralPrimm.Enabled = True
        btnSTATSGeneralStrip.Enabled = True
        btnSTATSGeneralWhiteGlove.Enabled = True
        ' display the relevant label
        lblSTATSGeneralNCR.Visible = True
        ' hide the remaining labels within the container
        lblSTATSGeneralBoomers.Visible = False
        lblSTATSGeneralBrotherhood.Visible = False
        lblSTATSGeneralLegion.Visible = False
        lblSTATSGeneralFollowers.Visible = False
        lblSTATSGeneralFreeside.Visible = False
        lblSTATSGeneralGoodsprings.Visible = False
        lblSTATSGeneralGreatKhans.Visible = False
        lblSTATSGeneralNovac.Visible = False
        lblSTATSGeneralPowderGangers.Visible = False
        lblSTATSGeneralPrimm.Visible = False
        lblSTATSGeneralStrip.Visible = False
        lblSTATSGeneralWhiteGlove.Visible = False
    End Sub

    Private Sub btnSTATSGeneralNovac_Click(sender As Object, e As EventArgs) Handles btnSTATSGeneralNovac.Click
        ' disable the button clicked
        btnSTATSGeneralNovac.Enabled = False
        ' enable the other buttons
        btnSTATSGeneralBoomers.Enabled = True
        btnSTATSGeneralBrotherhood.Enabled = True
        btnSTATSGeneralLegion.Enabled = True
        btnSTATSGeneralFollowers.Enabled = True
        btnSTATSGeneralFreeside.Enabled = True
        btnSTATSGeneralGoodsprings.Enabled = True
        btnSTATSGeneralGreatKhans.Enabled = True
        btnSTATSGeneralNCR.Enabled = True
        btnSTATSGeneralPowderGangers.Enabled = True
        btnSTATSGeneralPrimm.Enabled = True
        btnSTATSGeneralStrip.Enabled = True
        btnSTATSGeneralWhiteGlove.Enabled = True
        ' display the relevant label
        lblSTATSGeneralNovac.Visible = True
        ' hide the remaining labels within the container
        lblSTATSGeneralBoomers.Visible = False
        lblSTATSGeneralBrotherhood.Visible = False
        lblSTATSGeneralLegion.Visible = False
        lblSTATSGeneralFollowers.Visible = False
        lblSTATSGeneralFreeside.Visible = False
        lblSTATSGeneralGoodsprings.Visible = False
        lblSTATSGeneralGreatKhans.Visible = False
        lblSTATSGeneralNCR.Visible = False
        lblSTATSGeneralPowderGangers.Visible = False
        lblSTATSGeneralPrimm.Visible = False
        lblSTATSGeneralStrip.Visible = False
        lblSTATSGeneralWhiteGlove.Visible = False
    End Sub

    Private Sub btnSTATSGeneralPowderGangers_Click(sender As Object, e As EventArgs) Handles btnSTATSGeneralPowderGangers.Click
        ' disable the button clicked
        btnSTATSGeneralPowderGangers.Enabled = False
        ' enable the other buttons
        btnSTATSGeneralBoomers.Enabled = True
        btnSTATSGeneralBrotherhood.Enabled = True
        btnSTATSGeneralLegion.Enabled = True
        btnSTATSGeneralFollowers.Enabled = True
        btnSTATSGeneralFreeside.Enabled = True
        btnSTATSGeneralGoodsprings.Enabled = True
        btnSTATSGeneralGreatKhans.Enabled = True
        btnSTATSGeneralNCR.Enabled = True
        btnSTATSGeneralNovac.Enabled = True
        btnSTATSGeneralPrimm.Enabled = True
        btnSTATSGeneralStrip.Enabled = True
        btnSTATSGeneralWhiteGlove.Enabled = True
        ' display the relevant label
        lblSTATSGeneralPowderGangers.Visible = True
        ' hide the remaining labels within the container
        lblSTATSGeneralBoomers.Visible = False
        lblSTATSGeneralBrotherhood.Visible = False
        lblSTATSGeneralLegion.Visible = False
        lblSTATSGeneralFollowers.Visible = False
        lblSTATSGeneralFreeside.Visible = False
        lblSTATSGeneralGoodsprings.Visible = False
        lblSTATSGeneralGreatKhans.Visible = False
        lblSTATSGeneralNCR.Visible = False
        lblSTATSGeneralNovac.Visible = False
        lblSTATSGeneralPrimm.Visible = False
        lblSTATSGeneralStrip.Visible = False
        lblSTATSGeneralWhiteGlove.Visible = False
    End Sub

    Private Sub btnSTATSGeneralPrimm_Click(sender As Object, e As EventArgs) Handles btnSTATSGeneralPrimm.Click
        ' disable the button clicked
        btnSTATSGeneralPrimm.Enabled = False
        ' enable the other buttons
        btnSTATSGeneralBoomers.Enabled = True
        btnSTATSGeneralBrotherhood.Enabled = True
        btnSTATSGeneralLegion.Enabled = True
        btnSTATSGeneralFollowers.Enabled = True
        btnSTATSGeneralFreeside.Enabled = True
        btnSTATSGeneralGoodsprings.Enabled = True
        btnSTATSGeneralGreatKhans.Enabled = True
        btnSTATSGeneralNCR.Enabled = True
        btnSTATSGeneralNovac.Enabled = True
        btnSTATSGeneralPowderGangers.Enabled = True
        btnSTATSGeneralStrip.Enabled = True
        btnSTATSGeneralWhiteGlove.Enabled = True
        ' display the relevant label
        lblSTATSGeneralPrimm.Visible = True
        ' hide the remaining labels within the container
        lblSTATSGeneralBoomers.Visible = False
        lblSTATSGeneralBrotherhood.Visible = False
        lblSTATSGeneralLegion.Visible = False
        lblSTATSGeneralFollowers.Visible = False
        lblSTATSGeneralFreeside.Visible = False
        lblSTATSGeneralGoodsprings.Visible = False
        lblSTATSGeneralGreatKhans.Visible = False
        lblSTATSGeneralNCR.Visible = False
        lblSTATSGeneralNovac.Visible = False
        lblSTATSGeneralPowderGangers.Visible = False
        lblSTATSGeneralStrip.Visible = False
        lblSTATSGeneralWhiteGlove.Visible = False
    End Sub

    Private Sub btnSTATSGeneralStrip_Click(sender As Object, e As EventArgs) Handles btnSTATSGeneralStrip.Click
        ' disable the button clicked
        btnSTATSGeneralStrip.Enabled = False
        ' enable the other buttons
        btnSTATSGeneralBoomers.Enabled = True
        btnSTATSGeneralBrotherhood.Enabled = True
        btnSTATSGeneralLegion.Enabled = True
        btnSTATSGeneralFollowers.Enabled = True
        btnSTATSGeneralFreeside.Enabled = True
        btnSTATSGeneralGoodsprings.Enabled = True
        btnSTATSGeneralGreatKhans.Enabled = True
        btnSTATSGeneralNCR.Enabled = True
        btnSTATSGeneralNovac.Enabled = True
        btnSTATSGeneralPowderGangers.Enabled = True
        btnSTATSGeneralPrimm.Enabled = True
        btnSTATSGeneralWhiteGlove.Enabled = True
        ' display the relevant label
        lblSTATSGeneralStrip.Visible = True
        ' hide the remaining labels within the container
        lblSTATSGeneralBoomers.Visible = False
        lblSTATSGeneralBrotherhood.Visible = False
        lblSTATSGeneralLegion.Visible = False
        lblSTATSGeneralFollowers.Visible = False
        lblSTATSGeneralFreeside.Visible = False
        lblSTATSGeneralGoodsprings.Visible = False
        lblSTATSGeneralGreatKhans.Visible = False
        lblSTATSGeneralNCR.Visible = False
        lblSTATSGeneralNovac.Visible = False
        lblSTATSGeneralPowderGangers.Visible = False
        lblSTATSGeneralPrimm.Visible = False
        lblSTATSGeneralWhiteGlove.Visible = False
    End Sub

    Private Sub btnSTATSGeneralWhiteGlove_Click(sender As Object, e As EventArgs) Handles btnSTATSGeneralWhiteGlove.Click
        ' disable the button clicked
        btnSTATSGeneralWhiteGlove.Enabled = False
        ' enable the other buttons
        btnSTATSGeneralBoomers.Enabled = True
        btnSTATSGeneralBrotherhood.Enabled = True
        btnSTATSGeneralLegion.Enabled = True
        btnSTATSGeneralFollowers.Enabled = True
        btnSTATSGeneralFreeside.Enabled = True
        btnSTATSGeneralGoodsprings.Enabled = True
        btnSTATSGeneralGreatKhans.Enabled = True
        btnSTATSGeneralNCR.Enabled = True
        btnSTATSGeneralNovac.Enabled = True
        btnSTATSGeneralPowderGangers.Enabled = True
        btnSTATSGeneralPrimm.Enabled = True
        btnSTATSGeneralStrip.Enabled = True
        ' display the relevant label
        lblSTATSGeneralWhiteGlove.Visible = True
        ' hide the remaining labels within the container
        lblSTATSGeneralBoomers.Visible = False
        lblSTATSGeneralBrotherhood.Visible = False
        lblSTATSGeneralLegion.Visible = False
        lblSTATSGeneralFollowers.Visible = False
        lblSTATSGeneralFreeside.Visible = False
        lblSTATSGeneralGoodsprings.Visible = False
        lblSTATSGeneralGreatKhans.Visible = False
        lblSTATSGeneralNCR.Visible = False
        lblSTATSGeneralNovac.Visible = False
        lblSTATSGeneralPowderGangers.Visible = False
        lblSTATSGeneralPrimm.Visible = False
        lblSTATSGeneralStrip.Visible = False
    End Sub

    Private Sub btnITEMS_Click(sender As Object, e As EventArgs) Handles btnITEMS.Click
        ' disable the button clicked
        btnITEMS.Enabled = False
        ' enable the other two main buttons
        btnSTATS.Enabled = True
        btnDATA.Enabled = True
        ' display the split container holding the relevant buttons
        splITEMS.Visible = True
        ' hide all other split containers
        splSTATS.Visible = False
        splSTATSStatus.Visible = False
        splSTATSSpecial.Visible = False
        splSTATSSkills.Visible = False
        splSTATSPerks.Visible = False
        splSTATSGeneral.Visible = False
        splITEMSWeapons.Visible = False
        splITEMSApparel.Visible = False
        splITEMSAid.Visible = False
        splITEMSMisc.Visible = False
        splITEMSAmmo.Visible = False
        splDATA.Visible = False
        splDATALocalMap.Visible = False
        splDATAWorldMap.Visible = False
        splDATAQuests.Visible = False
        splDATAMisc.Visible = False
        splDATARadio.Visible = False
        ' enable the relevant buttons
        btnITEMSWeapons.Enabled = True
        btnITEMSApparel.Enabled = True
        btnITEMSAid.Enabled = True
        btnITEMSMisc.Enabled = True
        btnITEMSAmmo.Enabled = True
    End Sub

    Private Sub btnITEMSWeapons_Click(sender As Object, e As EventArgs) Handles btnITEMSWeapons.Click
        ' disable the button clicked
        btnITEMSWeapons.Enabled = False
        ' enable the other buttons
        btnITEMSApparel.Enabled = True
        btnITEMSAid.Enabled = True
        btnITEMSMisc.Enabled = True
        btnITEMSAmmo.Enabled = True
        ' display the relevant container
        splITEMSWeapons.Visible = True
        ' hide the remaining containers of this group
        splITEMSApparel.Visible = False
        splITEMSAid.Visible = False
        splITEMSMisc.Visible = False
        splITEMSAmmo.Visible = False
        ' display the relevant label
        lblITEMSWeapons.Visible = True
    End Sub

    Private Sub btnITEMSApparel_Click(sender As Object, e As EventArgs) Handles btnITEMSApparel.Click
        ' disable the button clicked
        btnITEMSApparel.Enabled = False
        ' enable the other buttons
        btnITEMSWeapons.Enabled = True
        btnITEMSAid.Enabled = True
        btnITEMSMisc.Enabled = True
        btnITEMSAmmo.Enabled = True
        ' display the relevant container
        splITEMSApparel.Visible = True
        ' hide the remaining containers of this group
        splITEMSWeapons.Visible = False
        splITEMSAid.Visible = False
        splITEMSMisc.Visible = False
        splITEMSAmmo.Visible = False
        ' display the relevant label
        lblITEMSApparel.Visible = True
    End Sub

    Private Sub btnITEMSAid_Click(sender As Object, e As EventArgs) Handles btnITEMSAid.Click
        ' disable the button clicked
        btnITEMSAid.Enabled = False
        ' enable the other buttons
        btnITEMSWeapons.Enabled = True
        btnITEMSApparel.Enabled = True
        btnITEMSMisc.Enabled = True
        btnITEMSAmmo.Enabled = True
        ' display the relevant container
        splITEMSAid.Visible = True
        ' hide the remaining containers of this group
        splITEMSWeapons.Visible = False
        splITEMSApparel.Visible = False
        splITEMSMisc.Visible = False
        splITEMSAmmo.Visible = False
        ' display the relevant label
        lblITEMSAid.Visible = True
    End Sub

    Private Sub btnITEMSMisc_Click(sender As Object, e As EventArgs) Handles btnITEMSMisc.Click
        ' disable the button clicked
        btnITEMSMisc.Enabled = False
        ' enable the other buttons
        btnITEMSWeapons.Enabled = True
        btnITEMSApparel.Enabled = True
        btnITEMSAid.Enabled = True
        btnITEMSAmmo.Enabled = True
        ' display the relevant container
        splITEMSMisc.Visible = True
        ' hide the remaining containers of this group
        splITEMSWeapons.Visible = False
        splITEMSApparel.Visible = False
        splITEMSAid.Visible = False
        splITEMSAmmo.Visible = False
        ' display the relevant label
        lblITEMSMisc.Visible = True
    End Sub

    Private Sub btnITEMSAmmo_Click(sender As Object, e As EventArgs) Handles btnITEMSAmmo.Click
        ' disable the button clicked
        btnITEMSAmmo.Enabled = False
        ' enable the other buttons
        btnITEMSWeapons.Enabled = True
        btnITEMSApparel.Enabled = True
        btnITEMSAid.Enabled = True
        btnITEMSMisc.Enabled = True
        ' display the relevant container
        splITEMSAmmo.Visible = True
        ' hide the remaining containers of this group
        splITEMSWeapons.Visible = False
        splITEMSApparel.Visible = False
        splITEMSAid.Visible = False
        splITEMSMisc.Visible = False
        ' display the relevant label
        lblITEMSAmmo.Visible = True
    End Sub

    Private Sub btnDATA_Click(sender As Object, e As EventArgs) Handles btnDATA.Click
        ' disable the button clicked
        btnDATA.Enabled = False
        ' enable the other two main buttons
        btnSTATS.Enabled = True
        btnITEMS.Enabled = True
        ' display the split container holding the relevant buttons
        splDATA.Visible = True
        ' hide all other split containers
        splSTATS.Visible = False
        splSTATSStatus.Visible = False
        splSTATSSpecial.Visible = False
        splSTATSSkills.Visible = False
        splSTATSPerks.Visible = False
        splSTATSGeneral.Visible = False
        splITEMS.Visible = False
        splITEMSWeapons.Visible = False
        splITEMSApparel.Visible = False
        splITEMSAid.Visible = False
        splITEMSMisc.Visible = False
        splITEMSAmmo.Visible = False
        splDATALocalMap.Visible = False
        splDATAWorldMap.Visible = False
        splDATAQuests.Visible = False
        splDATAMisc.Visible = False
        splDATARadio.Visible = False
        ' enable the relevant buttons
        btnDATALocalMap.Enabled = True
        btnDATAWorldMap.Enabled = True
        btnDATAQuests.Enabled = True
        btnDATAMisc.Enabled = True
        btnDATARadio.Enabled = True
    End Sub

    Private Sub btnDATALocalMap_Click(sender As Object, e As EventArgs) Handles btnDATALocalMap.Click
        ' disable the button clicked
        btnDATALocalMap.Enabled = False
        ' enable the other buttons
        btnDATAWorldMap.Enabled = True
        btnDATAQuests.Enabled = True
        btnDATAMisc.Enabled = True
        btnDATARadio.Enabled = True
        ' display the relevant container
        splDATALocalMap.Visible = True
        ' hide the remaining containers of this group
        splDATAWorldMap.Visible = False
        splDATAQuests.Visible = False
        splDATAMisc.Visible = False
        splDATARadio.Visible = False
        ' display the relevant label
        lblDATALocalMap.Visible = True
    End Sub

    Private Sub btnDATAWorldMap_Click(sender As Object, e As EventArgs) Handles btnDATAWorldMap.Click
        ' disable the button clicked
        btnDATAWorldMap.Enabled = False
        ' enable the other buttons
        btnDATALocalMap.Enabled = True
        btnDATAQuests.Enabled = True
        btnDATAMisc.Enabled = True
        btnDATARadio.Enabled = True
        ' display the relevant container
        splDATAWorldMap.Visible = True
        ' hide the remaining containers of this group
        splDATALocalMap.Visible = False
        splDATAQuests.Visible = False
        splDATAMisc.Visible = False
        splDATARadio.Visible = False
        ' display the relevant label
        lblDATAWorldMap.Visible = True
    End Sub

    Private Sub btnDATAQuests_Click(sender As Object, e As EventArgs) Handles btnDATAQuests.Click
        ' disable the button clicked
        btnDATAQuests.Enabled = False
        ' enable the other buttons
        btnDATALocalMap.Enabled = True
        btnDATAWorldMap.Enabled = True
        btnDATAMisc.Enabled = True
        btnDATARadio.Enabled = True
        ' display the relevant container
        splDATAQuests.Visible = True
        ' hide the remaining containers of this group
        splDATALocalMap.Visible = False
        splDATAWorldMap.Visible = False
        splDATAMisc.Visible = False
        splDATARadio.Visible = False
        ' display the relevant label
        lblDATAQuests.Visible = True
    End Sub

    Private Sub btnDATAMisc_Click(sender As Object, e As EventArgs) Handles btnDATAMisc.Click
        ' disable the button clicked
        btnDATAMisc.Enabled = False
        ' enable the other buttons
        btnDATALocalMap.Enabled = True
        btnDATAWorldMap.Enabled = True
        btnDATAQuests.Enabled = True
        btnDATARadio.Enabled = True
        ' display the relevant container
        splDATAMisc.Visible = True
        ' hide the remaining containers of this group
        splDATALocalMap.Visible = False
        splDATAWorldMap.Visible = False
        splDATAQuests.Visible = False
        splDATARadio.Visible = False
        ' display the relevant label
        lblDATAMisc.Visible = True
    End Sub

    Private Sub btnDATARadio_Click(sender As Object, e As EventArgs) Handles btnDATARadio.Click
        ' disable the button clicked
        btnDATARadio.Enabled = False
        ' enable the other buttons
        btnDATALocalMap.Enabled = True
        btnDATAWorldMap.Enabled = True
        btnDATAQuests.Enabled = True
        btnDATAMisc.Enabled = True
        ' display the relevant container
        splDATARadio.Visible = True
        ' hide the remaining containers of this group
        splDATALocalMap.Visible = False
        splDATAWorldMap.Visible = False
        splDATAQuests.Visible = False
        splDATAMisc.Visible = False
        ' display the relevant label
        lblDATARadio.Visible = True
    End Sub
End Class
