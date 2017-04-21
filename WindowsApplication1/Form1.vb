'Dim testDie As New Random
'Dim random As Integer = testDie.Next(1, 13)
'If random = 1 Then
'TextBox1.Text = ""
'ElseIf random = 2 Then
'TextBox1.Text = ""
'ElseIf random = 3 Then
'TextBox1.Text = ""
'ElseIf random = 4 Then
'TextBox1.Text = ""
'ElseIf random = 5 Then
'TextBox1.Text = ""
'ElseIf random = 6 Then
'TextBox1.Text = ""
'ElseIf random = 7 Then
'TextBox1.Text = ""
'ElseIf random = 8 Then
'TextBox1.Text = ""
'ElseIf random = 9 Then
'TextBox1.Text = ""
'ElseIf random = 10 Then
'TextBox1.Text = ""
'ElseIf random = 11 Then
'TextBox1.Text = ""
'ElseIf random = 12 Then
'TextBox1.Text = ""
'ElseIf random = 13 Then
'TextBox1.Text = ""
'ElseIf random = 14 Then
'TextBox1.Text = ""
'ElseIf random = 15 Then
'TextBox1.Text = ""
'ElseIf random = 16 Then
'TextBox1.Text = ""
'ElseIf random = 17 Then
'TextBox1.Text = ""
'ElseIf random = 18 Then
'TextBox1.Text = ""
'ElseIf random = 19 Then
'TextBox1.Text = ""
'ElseIf random = 20 Then
'TextBox1.Text = ""
'End If
'TextBox2.Text = random
Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim testDie As New Random
        Dim random As Integer = testDie.Next(1, 21)
        If random = 1 Then
            TextBox1.Text = "Locate a dungeon or other site of interest (roll on
the Dungeon Goals table to find out why). "
        ElseIf random = 2 Then
            TextBox1.Text = "Assess the scope of a natural or unnatural disaster.  "
        ElseIf random = 3 Then
            TextBox1.Text = "Escort an NPC to a destination . "
        ElseIf random = 4 Then
            TextBox1.Text = "Arrive at a destination without being seen by the
vi ll ain's forces. "
        ElseIf random = 5 Then
            TextBox1.Text = "Stop monsters from raiding caravans and farms. "
        ElseIf random = 6 Then
            TextBox1.Text = "Establish trade with a distant town.  "
        ElseIf random = 7 Then
            TextBox1.Text = "Protect a caravan traveling to a distant town .  "
        ElseIf random = 8 Then
            TextBox1.Text = "Map a new land. "
        ElseIf random = 9 Then
            TextBox1.Text = "Find a place to establish a colony. "
        ElseIf random = 10 Then
            TextBox1.Text = "Fi nd a natural resource. "
        ElseIf random = 11 Then
            TextBox1.Text = "Hunt a specific monster. "
        ElseIf random = 12 Then
            TextBox1.Text = "Return home from a distant place. "
        ElseIf random = 13 Then
            TextBox1.Text = "Obtain information from a reclusive hermit. "
        ElseIf random = 14 Then
            TextBox1.Text = " Find an object that was lost in the wi ld s. "
        ElseIf random = 15 Then
            TextBox1.Text = "Discover the fate of a missing group of explorers.  "
        ElseIf random = 16 Then
            TextBox1.Text = "Pursue fleeing foes. "
        ElseIf random = 17 Then
            TextBox1.Text = "Assess the size of an approaching army. "
        ElseIf random = 18 Then
            TextBox1.Text = "Escape the re ign of a tyrant. "
        ElseIf random = 19 Then
            TextBox1.Text = "Protect a wilderness site from attackers. "
        ElseIf random = 20 Then
            TextBox1.Text = "Roll twice, ign oring results of 20. "
        End If
        TextBox2.Text = random

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim testDie As New Random
        Dim random As Integer = testDie.Next(1, 21)
        If random = 1 Then
            TextBox1.Text = "Stop the dungeon's monstrous inhabitants from
raiding the surface world . "
        ElseIf random = 2 Then
            TextBox1.Text = "Foil a villain's evil scheme. "
        ElseIf random = 3 Then
            TextBox1.Text = "Destroy a magical threat inside the dungeon. "
        ElseIf random = 4 Then
            TextBox1.Text = "Acquire treasure . "
        ElseIf random = 5 Then
            TextBox1.Text = "Find a particular item for a specific purpose. "
        ElseIf random = 6 Then
            TextBox1.Text = "Retrieve a stolen item hidden in the dungeon. "
        ElseIf random = 7 Then
            TextBox1.Text = "Find information needed for a specia l purpose. "
        ElseIf random = 8 Then
            TextBox1.Text = "Rescue a captive. "
        ElseIf random = 9 Then
            TextBox1.Text = "Discover the fate of a previous adventuring party. "
        ElseIf random = 10 Then
            TextBox1.Text = "Find an N PC who disappeared in the area. "
        ElseIf random = 11 Then
            TextBox1.Text = "Slay a dragon or some other challenging monster."
        ElseIf random = 12 Then
            TextBox1.Text = "Discover the nature and origin of a strange location
or phenomenon. "
        ElseIf random = 13 Then
            TextBox1.Text = "Pursue fleeing foes taking refuge in the dungeon. "
        ElseIf random = 14 Then
            TextBox1.Text = "Escape from captivity in the dungeon. "
        ElseIf random = 15 Then
            TextBox1.Text = "Clear a ruin so it can be rebuilt and reoccupied. "
        ElseIf random = 16 Then
            TextBox1.Text = "Discover why a villain is interested in the dungeon. "
        ElseIf random = 17 Then
            TextBox1.Text = "Win a bet or complete a rite of passage by surviving
in the dungeon for a certain amount oftime. "
        ElseIf random = 18 Then
            TextBox1.Text = "Parley with a vi llain in the dungeon. "
        ElseIf random = 19 Then
            TextBox1.Text = "Hide from a threat outside the dungeon. "
        ElseIf random = 20 Then
            TextBox1.Text = "Roll twice, ignoring resu lts of 20. "
        End If
        TextBox2.Text = random
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim testDie As New Random
        Dim random As Integer = testDie.Next(1, 13)
        If random = 1 Then
            TextBox1.Text = "Seize control of a fortified location such as a
fortress, town, or ship. "
        ElseIf random = 2 Then
            TextBox1.Text = "Defend a location from attackers. "
        ElseIf random = 3 Then
            TextBox1.Text = "Retrieve an object from inside a secure location in
a settlement. "
        ElseIf random = 4 Then
            TextBox1.Text = "Retrieve an object from a caravan. "
        ElseIf random = 5 Then
            TextBox1.Text = "Salvage an object or goods from a lost vessel or
caravan. "
        ElseIf random = 6 Then
            TextBox1.Text = "Break a prisoner out of a ja il or prison camp. "
        ElseIf random = 7 Then
            TextBox1.Text = "Escape from a jai l or prison camp. "
        ElseIf random = 8 Then
            TextBox1.Text = "Successfully travel through an obstacle course to
gain recognition or reward . "
        ElseIf random = 9 Then
            TextBox1.Text = "Infiltrate a fortified location. "
        ElseIf random = 10 Then
            TextBox1.Text = "Find the source of strange occurrences in a
haunted house or other location. "
        ElseIf random = 11 Then
            TextBox1.Text = "Interfere with the operation of a business. "
        ElseIf random = 12 Then
            TextBox1.Text = "Rescue a character, monster, or object from a
natural or unnatural disaster. "
        End If
        TextBox2.Text = random
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim testDie As New Random
        Dim random As Integer = testDie.Next(1, 21)
        If random = 1 Then
            TextBox1.Text = "Retired adventurer "
        ElseIf random = 2 Then
            TextBox1.Text = "Retired adventurer "
        ElseIf random = 3 Then
            TextBox1.Text = "Local ruler "
        ElseIf random = 4 Then
            TextBox1.Text = "Local ruler "
        ElseIf random = 5 Then
            TextBox1.Text = "Military officer "
        ElseIf random = 6 Then
            TextBox1.Text = "Military officer "
        ElseIf random = 7 Then
            TextBox1.Text = "Temple official "
        ElseIf random = 8 Then
            TextBox1.Text = "Temple official "
        ElseIf random = 9 Then
            TextBox1.Text = "Sage "
        ElseIf random = 10 Then
            TextBox1.Text = "Sage "
        ElseIf random = 11 Then
            TextBox1.Text = "Respected elder "
        ElseIf random = 12 Then
            TextBox1.Text = "Respected elder "
        ElseIf random = 13 Then
            TextBox1.Text = "Deity or celestial "
        ElseIf random = 14 Then
            TextBox1.Text = "Mysterious fey "
        ElseIf random = 15 Then
            TextBox1.Text = "Old friend"
        ElseIf random = 16 Then
            TextBox1.Text = "Former teacher"
        ElseIf random = 17 Then
            TextBox1.Text = "Parent or other
7-8 Temple official family member "
        ElseIf random = 18 Then
            TextBox1.Text = "Desperate
11-12 Respected elder commoner "
        ElseIf random = 19 Then
            TextBox1.Text = "Embattled
14 Mysterious fey merchant "
        ElseIf random = 20 Then
            TextBox1.Text = "Villain posing as a
patron "
        End If
        TextBox2.Text = random
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim testDie As New Random
        Dim random As Integer = testDie.Next(1, 21)
        If random = 1 Then
            TextBox1.Text = "Beast or monstrosity with no particular agenda "
        ElseIf random = 2 Then
            TextBox1.Text = "Aberration bent on corruption or domination "
        ElseIf random = 3 Then
            TextBox1.Text = "Fiend bent on corruption or destruction "
        ElseIf random = 4 Then
            TextBox1.Text = "Dragon bent on domination and plunder "
        ElseIf random = 5 Then
            TextBox1.Text = "Giant bent on plunder "
        ElseIf random = 6 Then
            TextBox1.Text = "Undead with any agenda "
        ElseIf random = 7 Then
            TextBox1.Text = "Undead with any agenda "
        ElseIf random = 8 Then
            TextBox1.Text = "Fey with a mysterious goal "
        ElseIf random = 9 Then
            TextBox1.Text = "Humanoid cultis"
        ElseIf random = 10 Then
            TextBox1.Text = "Humanoid cultis"
        ElseIf random = 11 Then
            TextBox1.Text = "Humanoid conqueror"
        ElseIf random = 12 Then
            TextBox1.Text = "Humanoid conqueror"
        ElseIf random = 13 Then
            TextBox1.Text = "Humano id seeking revenge "
        ElseIf random = 14 Then
            TextBox1.Text = "Humanoid schemer seeking to rule"
        ElseIf random = 15 Then
            TextBox1.Text = "Humanoid schemer seeking to rule"
        ElseIf random = 16 Then
            TextBox1.Text = "Humanoid criminal mastermind "
        ElseIf random = 17 Then
            TextBox1.Text = "Humanoid raider or ravager"
        ElseIf random = 18 Then
            TextBox1.Text = "Humanoid raider or ravager"
        ElseIf random = 19 Then
            TextBox1.Text = "Humanoid under a curse"
        ElseIf random = 20 Then
            TextBox1.Text = "Misguided humanoid zealot"
        End If
        TextBox2.Text = random
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim testDie As New Random
        Dim random As Integer = testDie.Next(1, 13)
        If random = 1 Then
            TextBox1.Text = "Skilled adventurer "
        ElseIf random = 2 Then
            TextBox1.Text = "Inexperienced Adventurer"
        ElseIf random = 3 Then
            TextBox1.Text = "Enthusiastic Commoner"
        ElseIf random = 4 Then
            TextBox1.Text = "Soldier"
        ElseIf random = 5 Then
            TextBox1.Text = "Priest"
        ElseIf random = 6 Then
            TextBox1.Text = "Sage"
        ElseIf random = 7 Then
            TextBox1.Text = "Revenge Seeker"
        ElseIf random = 8 Then
            TextBox1.Text = "Raving Lunatic"
        ElseIf random = 9 Then
            TextBox1.Text = "Celestial Ally"
        ElseIf random = 10 Then
            TextBox1.Text = "Fey Ally"
        ElseIf random = 11 Then
            TextBox1.Text = "Disguised Monster"
        ElseIf random = 12 Then
            TextBox1.Text = "Villain posing as an Ally "
        End If
        TextBox2.Text = random
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim testDie As New Random
        Dim random As Integer = testDie.Next(1, 13)
        If random = 1 Then
            TextBox1.Text = "While traveling in the wilderness, the characters
fall into a sinkhole that opens beneath their feet,
dropping them into the adventure location. "
        ElseIf random = 2 Then
            TextBox1.Text = "While traveling in the wilderness, the characters
notice the entrance to the adve nture location. "
        ElseIf random = 3 Then
            TextBox1.Text = "While traveling on a road, the characters are
attacked by monsters that flee into the nearby
adventure location. "
        ElseIf random = 4 Then
            TextBox1.Text = "The adventurers find a map on a dead body. In
add ition to the map setting up the adventure, the
adventure's villain wants the map. "
        ElseIf random = 5 Then
            TextBox1.Text = "A mysterious magic item or a cruel vi llain teleports
the characters to the adventure location ."
        ElseIf random = 6 Then
            TextBox1.Text = "A stranger approaches the characters in a tavern
and urges them toward the adventure location. "
        ElseIf random = 7 Then
            TextBox1.Text = "A town or village needs vo lunteers to go to the
adventure location. "
        ElseIf random = 8 Then
            TextBox1.Text = "An NPC the characters care about needs them to
go to the adventure location. "
        ElseIf random = 9 Then
            TextBox1.Text = "An NPC the characters must obey orders them to
go to the adventure location. "
        ElseIf random = 10 Then
            TextBox1.Text = "An NPC the characters respect asks them to go to
the adve nture location. "
        ElseIf random = 11 Then
            TextBox1.Text = "One night, the characters all dream about entering
the adventure location. "
        ElseIf random = 12 Then
            TextBox1.Text = "A ghost appears and terrorizes a village. Research
reveals that it can be put to rest only by entering the
adventure location. "
        End If
        TextBox2.Text = random
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim testDie As New Random
        Dim random As Integer = testDie.Next(1, 13)
        If random = 1 Then
            TextBox1.Text = "The adventurers confront the main villain and a
group of minions in a bloody battle to the finish. "
        ElseIf random = 2 Then
            TextBox1.Text = "The adventurers chase the villain while dodging
obstacles designed to thwart them, leading to a final
confrontation in or outside the villain's refuge. "
        ElseIf random = 3 Then
            TextBox1.Text = "The actions of the adventurers or the villain result
in a cataclysmic event that the adventurers must
escape. "
        ElseIf random = 4 Then
            TextBox1.Text = "The adventurers race to the site where the villain is
bringing a master plan to its conclusion, arriving
just as that plan is about to be completed. "
        ElseIf random = 5 Then
            TextBox1.Text = "The villain and two or three lieutenants perform
separate rites in a large room. The adventurers
must disrupt all the rites at the same time. "
        ElseIf random = 6 Then
            TextBox1.Text = "An ally betrays the adventurers as they're about to
achieve their goal. (Use this climax carefully, and
don't overuse it.) "
        ElseIf random = 7 Then
            TextBox1.Text = "A portal opens to another plane of existence.
Creatures on the other side spill out, forcing the
adventurers to close the portal and deal with the
villain at the same time. "
        ElseIf random = 8 Then
            TextBox1.Text = "Traps, hazards, or animated objects turn against
the adventurers while the main villain attacks. "
        ElseIf random = 9 Then
            TextBox1.Text = "The dungeon begins to collapse while the
adventurers face the main villain, who attempts to
escape in the chaos. "
        ElseIf random = 10 Then
            TextBox1.Text = "A threat more powerful than the adventurers
appears, destroys the main villain, and then turns
its attention on the characters. "
        ElseIf random = 11 Then
            TextBox1.Text = "The adventurers must choose whether to pursue
the fleeing main villain or save an N PC they care
about or a group of innocents. "
        ElseIf random = 12 Then
            TextBox1.Text = "The adventurers must discover the main villain's
secret weakness before they can hope to defeat that
villain . "
        End If
        TextBox2.Text = random
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim testDie As New Random
        Dim random As Integer = testDie.Next(1, 7)
        If random = 1 Then
            TextBox1.Text = "Big Event"
        ElseIf random = 2 Then
            TextBox1.Text = "Crime Spree"
        ElseIf random = 3 Then
            TextBox1.Text = "Growing Corruption"
        ElseIf random = 4 Then
            TextBox1.Text = "One and Done"
        ElseIf random = 5 Then
            TextBox1.Text = "Serial Crimes"
        ElseIf random = 6 Then
            TextBox1.Text = "Step by Step"
        End If
        TextBox2.Text = random
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim testDie As New Random
        Dim random As Integer = testDie.Next(1, 21)
        If random = 1 Then
            TextBox1.Text = "Bring the villain to justice. "
        ElseIf random = 2 Then
            TextBox1.Text = "Clear the name of an innocent N PC. "
        ElseIf random = 3 Then
            TextBox1.Text = "Protect or hide an N PC. "
        ElseIf random = 4 Then
            TextBox1.Text = "Protect an object. "
        ElseIf random = 5 Then
            TextBox1.Text = "Discover the nature and origin of a strange
phenomenon that might be the villain's doing. "
        ElseIf random = 6 Then
            TextBox1.Text = "Find a wanted fugitive. "
        ElseIf random = 7 Then
            TextBox1.Text = "Overthrow a tyrant."
        ElseIf random = 8 Then
            TextBox1.Text = "Uncover a conspiracy to overthrow a ruler. "
        ElseIf random = 9 Then
            TextBox1.Text = "Negotiate peace between enemy nations or feuding
families. "
        ElseIf random = 10 Then
            TextBox1.Text = "Secure aid from a ruler or council."
        ElseIf random = 11 Then
            TextBox1.Text = "Help a villain find redemption. "
        ElseIf random = 12 Then
            TextBox1.Text = "Parley with a villain. "
        ElseIf random = 13 Then
            TextBox1.Text = "Smuggle weapons to rebel forces. "
        ElseIf random = 14 Then
            TextBox1.Text = "Stop a band of smugglers. "
        ElseIf random = 15 Then
            TextBox1.Text = "Gather intelligence on an enemy force. "
        ElseIf random = 16 Then
            TextBox1.Text = "Win a tournament."
        ElseIf random = 17 Then
            TextBox1.Text = "Determine the vi llain's identity. "
        ElseIf random = 18 Then
            TextBox1.Text = "Locate a stolen item. "
        ElseIf random = 19 Then
            TextBox1.Text = "Make sure a wedding goes off without a hitch. "
        ElseIf random = 20 Then
            TextBox1.Text = "Roll twice, ignoring results of 20. "
        End If
        TextBox2.Text = random
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim testDie As New Random
        Dim random As Integer = testDie.Next(1, 101)
        If random = 1 Then
            TextBox1.Text = "Anniversary of a monarch 's reign"
        ElseIf random = 2 Then
            TextBox1.Text = "Anniversary of a monarch 's reign"
        ElseIf random = 3 Then
            TextBox1.Text = "Anniversary of an important event "
        ElseIf random = 4 Then
            TextBox1.Text = "Anniversary of an important event "
        ElseIf random = 5 Then
            TextBox1.Text = "Arena event "
        ElseIf random = 6 Then
            TextBox1.Text = "Arena event "
        ElseIf random = 7 Then
            TextBox1.Text = "Arrival of a caravan or ship "
        ElseIf random = 8 Then
            TextBox1.Text = "Arrival of a caravan or ship "
        ElseIf random = 9 Then
            TextBox1.Text = "Arrival of a circus "
        ElseIf random = 10 Then
            TextBox1.Text = "Arrival of a circus "
        ElseIf random = 11 Then
            TextBox1.Text = "Arrival of an important NPC"
        ElseIf random = 12 Then
            TextBox1.Text = "Arrival of an important NPC"
        ElseIf random = 13 Then
            TextBox1.Text = "Arrival of marching modrons"
        ElseIf random = 14 Then
            TextBox1.Text = "Arrival of marching modrons"
        ElseIf random = 15 Then
            TextBox1.Text = "Artistic performance "
        ElseIf random = 16 Then
            TextBox1.Text = "Artistic performance "
        ElseIf random = 17 Then
            TextBox1.Text = "Athletic event "
        ElseIf random = 18 Then
            TextBox1.Text = "Athletic event "
        ElseIf random = 19 Then
            TextBox1.Text = "Birth of a child "
        ElseIf random = 20 Then
            TextBox1.Text = "Birth of a child "
        ElseIf random = 21 Then
            TextBox1.Text = "Birthday of an important N PC"
        ElseIf random = 22 Then
            TextBox1.Text = "Birthday of an important N PC"
        ElseIf random = 23 Then
            TextBox1.Text = "Civic festival "
        ElseIf random = 24 Then
            TextBox1.Text = "Civic festival "
        ElseIf random = 25 Then
            TextBox1.Text = "Comet appearance "
        ElseIf random = 26 Then
            TextBox1.Text = "Comet appearance "
        ElseIf random = 27 Then
            TextBox1.Text = "Commemoration of a past tragedy "
        ElseIf random = 28 Then
            TextBox1.Text = "Commemoration of a past tragedy "
        ElseIf random = 29 Then
            TextBox1.Text = "Consecration of a new temple "
        ElseIf random = 30 Then
            TextBox1.Text = "Consecration of a new temple "
        ElseIf random = 31 Then
            TextBox1.Text = "Coronation "
        ElseIf random = 32 Then
            TextBox1.Text = "Coronation "
        ElseIf random = 33 Then
            TextBox1.Text = "Council meeting"
        ElseIf random = 34 Then
            TextBox1.Text = "Council meeting"
        ElseIf random = 35 Then
            TextBox1.Text = "Equinox or solstice "
        ElseIf random = 36 Then
            TextBox1.Text = "Equinox or solstice "
        ElseIf random = 37 Then
            TextBox1.Text = "Execution "
        ElseIf random = 38 Then
            TextBox1.Text = "Execution "
        ElseIf random = 39 Then
            TextBox1.Text = "Fertility festival"
        ElseIf random = 40 Then
            TextBox1.Text = "Fertility festival"
        ElseIf random = 41 Then
            TextBox1.Text = "Full moon "
        ElseIf random = 42 Then
            TextBox1.Text = "Full moon "
        ElseIf random = 43 Then
            TextBox1.Text = "Funeral "
        ElseIf random = 44 Then
            TextBox1.Text = "Funeral "
        ElseIf random = 45 Then
            TextBox1.Text = "Graduation of cadets or wizards "
        ElseIf random = 46 Then
            TextBox1.Text = "Graduation of cadets or wizards "
        ElseIf random = 47 Then
            TextBox1.Text = "Harvest festival"
        ElseIf random = 48 Then
            TextBox1.Text = "Harvest festival"
        ElseIf random = 49 Then
            TextBox1.Text = "Holy day "
        ElseIf random = 50 Then
            TextBox1.Text = "Holy day "
        ElseIf random = 51 Then
            TextBox1.Text = "Investiture of a knight or other noble "
        ElseIf random = 52 Then
            TextBox1.Text = "Investiture of a knight or other noble "
        ElseIf random = 53 Then
            TextBox1.Text = "Lunar eclipse "
        ElseIf random = 54 Then
            TextBox1.Text = "Lunar eclipse "
        ElseIf random = 55 Then
            TextBox1.Text = "Midsummer festi va l "
        ElseIf random = 56 Then
            TextBox1.Text = "Midsummer festi va l "
        ElseIf random = 57 Then
            TextBox1.Text = "Midsummer festi va l "
        ElseIf random = 58 Then
            TextBox1.Text = "Midsummer festi va l "
        ElseIf random = 59 Then
            TextBox1.Text = "Midwinter festival "
        ElseIf random = 60 Then
            TextBox1.Text = "Midwinter festival "
        ElseIf random = 61 Then
            TextBox1.Text = "Migration of monsters "
        ElseIf random = 62 Then
            TextBox1.Text = "Migration of monsters "
        ElseIf random = 63 Then
            TextBox1.Text = "Monarch's ball "
        ElseIf random = 64 Then
            TextBox1.Text = "Monarch's ball "
        ElseIf random = 65 Then
            TextBox1.Text = "New Moon "
        ElseIf random = 66 Then
            TextBox1.Text = "New Moon"
        ElseIf random = 67 Then
            TextBox1.Text = "New yea r "
        ElseIf random = 68 Then
            TextBox1.Text = "New yea r "
        ElseIf random = 69 Then
            TextBox1.Text = "Pardoning of a prisoner "
        ElseIf random = 70 Then
            TextBox1.Text = "Pardoning of a prisoner "
        ElseIf random = 71 Then
            TextBox1.Text = "Planar conjunction "
        ElseIf random = 72 Then
            TextBox1.Text = "Planar conjunction "
        ElseIf random = 73 Then
            TextBox1.Text = "Planetary alignment "
        ElseIf random = 74 Then
            TextBox1.Text = "Planetary alignment "
        ElseIf random = 75 Then
            TextBox1.Text = "Priestly investiture "
        ElseIf random = 76 Then
            TextBox1.Text = "Priestly investiture "
        ElseIf random = 77 Then
            TextBox1.Text = "Procession of ghosts"
        ElseIf random = 78 Then
            TextBox1.Text = "Procession of ghosts"
        ElseIf random = 79 Then
            TextBox1.Text = "Remembrance for soldiers lost in war "
        ElseIf random = 80 Then
            TextBox1.Text = "Remembrance for soldiers lost in war "
        ElseIf random = 81 Then
            TextBox1.Text = "Royal address or proclamation "
        ElseIf random = 82 Then
            TextBox1.Text = "Royal address or proclamation "
        ElseIf random = 83 Then
            TextBox1.Text = "Royal audience day "
        ElseIf random = 84 Then
            TextBox1.Text = "Royal audience day "
        ElseIf random = 85 Then
            TextBox1.Text = "Signing of a treaty "
        ElseIf random = 86 Then
            TextBox1.Text = "Signing of a treaty "
        ElseIf random = 87 Then
            TextBox1.Text = "Solar eclipse"
        ElseIf random = 88 Then
            TextBox1.Text = "Solar eclipse"
        ElseIf random = 89 Then
            TextBox1.Text = "Tournament"
        ElseIf random = 90 Then
            TextBox1.Text = "Tournament"
        ElseIf random = 91 Then
            TextBox1.Text = "Tournament"
        ElseIf random = 92 Then
            TextBox1.Text = "Trial "
        ElseIf random = 93 Then
            TextBox1.Text = "Trial "
        ElseIf random = 94 Then
            TextBox1.Text = "Trial "
        ElseIf random = 95 Then
            TextBox1.Text = "Violent uprising"
        ElseIf random = 96 Then
            TextBox1.Text = "Violent uprising"
        ElseIf random = 97 Then
            TextBox1.Text = "Wedding or wedding anniversary"
        ElseIf random = 98 Then
            TextBox1.Text = "Wedding or wedding anniversary"
        ElseIf random = 99 Then
            TextBox1.Text = "Concurrence of two events (roll twice, ignoring
results of99 or 100) "
        ElseIf random = 100 Then
            TextBox1.Text = "Concurrence of two events (roll twice, ignoring
results of99 or 100) "
        End If
        TextBox2.Text = random
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim testDie As New Random
        Dim random As Integer = testDie.Next(1, 21)
        If random = 1 Then
            TextBox1.Text = "Ally Quandary"
        ElseIf random = 2 Then
            TextBox1.Text = "Ally Quandary"
        ElseIf random = 3 Then
            TextBox1.Text = "Ally Quandary"
        ElseIf random = 4 Then
            TextBox1.Text = "Friend Quandary"
        ElseIf random = 5 Then
            TextBox1.Text = "Friend Quandary"
        ElseIf random = 6 Then
            TextBox1.Text = "Friend Quandary"
        ElseIf random = 7 Then
            TextBox1.Text = "Honor Quandary"
        ElseIf random = 8 Then
            TextBox1.Text = "Honor Quandary"
        ElseIf random = 9 Then
            TextBox1.Text = "Honor Quandary"
        ElseIf random = 10 Then
            TextBox1.Text = "Honor Quandary"
        ElseIf random = 11 Then
            TextBox1.Text = "Honor Quandary"
        ElseIf random = 12 Then
            TextBox1.Text = "Honor Quandary"
        ElseIf random = 13 Then
            TextBox1.Text = "Rescue Quandary"
        ElseIf random = 14 Then
            TextBox1.Text = "Rescue Quandary"
        ElseIf random = 15 Then
            TextBox1.Text = "Rescue Quandary"
        ElseIf random = 16 Then
            TextBox1.Text = "Rescue Quandary"
        ElseIf random = 17 Then
            TextBox1.Text = "Respect Quandary"
        ElseIf random = 18 Then
            TextBox1.Text = "Respect Quandary"
        ElseIf random = 19 Then
            TextBox1.Text = "Respect Quandary"
        ElseIf random = 20 Then
            TextBox1.Text = "Respect Quandary"
        End If
        TextBox2.Text = random
    End Sub
End Class
'Dim testDie As New Random
'Dim random As Integer = testDie.Next(1, 21)
'If random = 1 Then
'TextBox1.Text = ""
'ElseIf random = 2 Then
'TextBox1.Text = ""
'ElseIf random = 3 Then
'TextBox1.Text = ""
'ElseIf random = 4 Then
'TextBox1.Text = ""
'ElseIf random = 5 Then
'TextBox1.Text = ""
'ElseIf random = 6 Then
'TextBox1.Text = ""
'ElseIf random = 7 Then
'TextBox1.Text = ""
'ElseIf random = 8 Then
'TextBox1.Text = ""
'ElseIf random = 9 Then
'TextBox1.Text = ""
'ElseIf random = 10 Then
'TextBox1.Text = ""
'ElseIf random = 11 Then
'TextBox1.Text = ""
'ElseIf random = 12 Then
'TextBox1.Text = ""
'ElseIf random = 13 Then
'TextBox1.Text = ""
'ElseIf random = 14 Then
'TextBox1.Text = ""
'ElseIf random = 15 Then
'TextBox1.Text = ""
'ElseIf random = 16 Then
'TextBox1.Text = ""
'ElseIf random = 17 Then
'TextBox1.Text = ""
'ElseIf random = 18 Then
'TextBox1.Text = ""
'ElseIf random = 19 Then
'TextBox1.Text = ""
'ElseIf random = 20 Then
'TextBox1.Text = ""
'End If
'TextBox2.Text = random

'Dim testDie As New Random
'Dim random As Integer = testDie.Next(1, 101)
'If random = 1 Then
'TextBox1.Text = ""
'ElseIf random = 2 Then
'TextBox1.Text = ""
'ElseIf random = 3 Then
'TextBox1.Text = ""
'ElseIf random = 4 Then
'TextBox1.Text = ""
'ElseIf random = 5 Then
'TextBox1.Text = ""
'ElseIf random = 6 Then
'TextBox1.Text = ""
'ElseIf random = 7 Then
'TextBox1.Text = ""
'ElseIf random = 8 Then
'TextBox1.Text = ""
'ElseIf random = 9 Then
'TextBox1.Text = ""
'ElseIf random = 10 Then
'TextBox1.Text = ""
'ElseIf random = 11 Then
'TextBox1.Text = ""
'ElseIf random = 12 Then
'TextBox1.Text = ""
'ElseIf random = 13 Then
'TextBox1.Text = ""
'ElseIf random = 14 Then
'TextBox1.Text = ""
'ElseIf random = 15 Then
'TextBox1.Text = ""
'ElseIf random = 16 Then
'TextBox1.Text = ""
'ElseIf random = 17 Then
'TextBox1.Text = ""
'ElseIf random = 18 Then
'TextBox1.Text = ""
'ElseIf random = 19 Then
'TextBox1.Text = ""
'ElseIf random = 20 Then
'TextBox1.Text = ""
'ElseIf random = 21 Then
'TextBox1.Text = ""
'ElseIf random = 22 Then
'TextBox1.Text = ""
'ElseIf random = 23 Then
'TextBox1.Text = ""
'ElseIf random = 24 Then
'TextBox1.Text = ""
'ElseIf random = 25 Then
'TextBox1.Text = ""
'ElseIf random = 26 Then
'TextBox1.Text = ""
'ElseIf random = 27 Then
'TextBox1.Text = ""
'ElseIf random = 28 Then
'TextBox1.Text = ""
'ElseIf random = 29 Then
'TextBox1.Text = ""
'ElseIf random = 30 Then
'TextBox1.Text = ""
'ElseIf random = 31 Then
'TextBox1.Text = ""
'ElseIf random = 32 Then
'TextBox1.Text = ""
'ElseIf random = 33 Then
'TextBox1.Text = ""
'ElseIf random = 34 Then
'TextBox1.Text = ""
'ElseIf random = 35 Then
'TextBox1.Text = ""
'ElseIf random = 36 Then
'TextBox1.Text = ""
'ElseIf random = 37 Then
'TextBox1.Text = ""
'ElseIf random = 38 Then
'TextBox1.Text = ""
'ElseIf random = 39 Then
'TextBox1.Text = ""
'ElseIf random = 40 Then
'TextBox1.Text = ""
'ElseIf random = 41 Then
'TextBox1.Text = ""
'ElseIf random = 42 Then
'TextBox1.Text = ""
'ElseIf random = 43 Then
'TextBox1.Text = ""
'ElseIf random = 44 Then
'TextBox1.Text = ""
'ElseIf random = 45 Then
'TextBox1.Text = ""
'ElseIf random = 46 Then
'TextBox1.Text = ""
'ElseIf random = 47 Then
'TextBox1.Text = ""
'ElseIf random = 48 Then
'TextBox1.Text = ""
'ElseIf random = 49 Then
'TextBox1.Text = ""
'ElseIf random = 50 Then
'TextBox1.Text = ""
'ElseIf random = 51 Then
'TextBox1.Text = ""
'ElseIf random = 52 Then
'TextBox1.Text = ""
'ElseIf random = 53 Then
'TextBox1.Text = ""
'ElseIf random = 54 Then
'TextBox1.Text = ""
'ElseIf random = 55 Then
'TextBox1.Text = ""
'ElseIf random = 56 Then
'TextBox1.Text = ""
'ElseIf random = 57 Then
'TextBox1.Text = ""
'ElseIf random = 58 Then
'TextBox1.Text = ""
'ElseIf random = 59 Then
'TextBox1.Text = ""
'ElseIf random = 60 Then
'TextBox1.Text = ""
'ElseIf random = 61 Then
'TextBox1.Text = ""
'ElseIf random = 62 Then
'TextBox1.Text = ""
'ElseIf random = 63 Then
'TextBox1.Text = ""
'ElseIf random = 64 Then
'TextBox1.Text = ""
'ElseIf random = 65 Then
'TextBox1.Text = ""
'ElseIf random = 67 Then
'TextBox1.Text = ""
'ElseIf random = 68 Then
'TextBox1.Text = ""
'ElseIf random = 69 Then
'TextBox1.Text = ""
'ElseIf random = 70 Then
'TextBox1.Text = ""
'ElseIf random = 71 Then
'TextBox1.Text = ""
'ElseIf random = 72 Then
'TextBox1.Text = ""
'ElseIf random = 73 Then
'TextBox1.Text = ""
'ElseIf random = 74 Then
'TextBox1.Text = ""
'ElseIf random = 75 Then
'TextBox1.Text = ""
'ElseIf random = 76 Then
'TextBox1.Text = ""
'ElseIf random = 77 Then
'TextBox1.Text = ""
'ElseIf random = 78 Then
'TextBox1.Text = ""
'ElseIf random = 79 Then
'TextBox1.Text = ""
'ElseIf random = 80 Then
'TextBox1.Text = ""
'ElseIf random = 81 Then
'TextBox1.Text = ""
'ElseIf random = 82 Then
'TextBox1.Text = ""
'ElseIf random = 83 Then
'TextBox1.Text = ""
'ElseIf random = 84 Then
'TextBox1.Text = ""
'ElseIf random = 85 Then
'TextBox1.Text = ""
'ElseIf random = 86 Then
'TextBox1.Text = ""
'ElseIf random = 87 Then
'TextBox1.Text = ""
'ElseIf random = 88 Then
'TextBox1.Text = ""
'ElseIf random = 89 Then
'TextBox1.Text = ""
'ElseIf random = 90 Then
'TextBox1.Text = ""
'ElseIf random = 91 Then
'TextBox1.Text = ""
'ElseIf random = 92 Then
'TextBox1.Text = ""
'ElseIf random = 93 Then
'TextBox1.Text = ""
'ElseIf random = 94 Then
'TextBox1.Text = ""
'ElseIf random = 95 Then
'TextBox1.Text = ""
'ElseIf random = 96 Then
'TextBox1.Text = ""
'ElseIf random = 97 Then
'TextBox1.Text = ""
'ElseIf random = 98 Then
'TextBox1.Text = ""
'ElseIf random = 99 Then
'TextBox1.Text = ""
'ElseIf random = 100 Then
'TextBox1.Text = ""
'End If
'TextBox2.Text = random