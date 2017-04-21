Public Class RollerForm
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

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim testDie As New Random
        Dim random As Integer = testDie.Next(1, 11)
        If random = 1 Then
            TextBox1.Text = "The adventurers are racing against other creatures
with the same or opposite goal. "
        ElseIf random = 2 Then
            TextBox1.Text = "The adventurers become responsible for the safety
of a noncombatant NPC. "
        ElseIf random = 3 Then
            TextBox1.Text = "The adventurers are prohibited from killing the
villain, but the villain has no compunctions about
killing them. "
        ElseIf random = 4 Then
            TextBox1.Text = "The adventurers have a time limit. "
        ElseIf random = 5 Then
            TextBox1.Text = "The adventurers have received false or extraneous
information. "
        ElseIf random = 6 Then
            TextBox1.Text = "Completing an adventure goal fulfills a prophecy or prevents the fulfillment of a prophecy."
        ElseIf random = 7 Then
            TextBox1.Text = "The adventurers have two different goals, but they
can complete only one. "
        ElseIf random = 8 Then
            TextBox1.Text = "Completing the goal secretly helps the villain. "
        ElseIf random = 9 Then
            TextBox1.Text = "The adventurers must cooperate with a known
enemy to achieve the goal. "
        ElseIf random = 10 Then
            TextBox1.Text = "The adventurers are under magica l compulsion
(such as a geas spell) to complete the ir goal. "
        End If
        TextBox2.Text = random
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim testDie As New Random
        Dim random As Integer = testDie.Next(1, 9)
        If random = 1 Then
            TextBox1.Text = "Find a specific item rumored to be in the area. "
        ElseIf random = 2 Then
            TextBox1.Text = "Retrieve a stolen item in t he vil lain's possession . "
        ElseIf random = 3 Then
            TextBox1.Text = "Receive information from an NPC in the area . "
        ElseIf random = 4 Then
            TextBox1.Text = "Rescue a captive . "
        ElseIf random = 5 Then
            TextBox1.Text = "Discover the fate of a missing NPC. "
        ElseIf random = 6 Then
            TextBox1.Text = "Slay a specific monster. "
        ElseIf random = 7 Then
            TextBox1.Text = "Discove r the nature and origin of a strange
phenomenon in the area. "
        ElseIf random = 8 Then
            TextBox1.Text = "Secure the aid of a character or creature in the area. "
        End If
        TextBox2.Text = random
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim testDie As New Random
        Dim random2 As Integer = testDie.Next(1, 9)
        Dim random3 As Integer = testDie.Next(1, 13)
        Dim random As Integer
        random = random2 + random3
        If random = 2 Then
            TextBox1.Text = "1 displacer beast "
        ElseIf random = 3 Then
            TextBox1.Text = "1 gnoll pack lord and 2d4 gnolls"
        ElseIf random = 4 Then
            TextBox1.Text = "1d4 gnolls and 2d4 hyenas "
        ElseIf random = 5 Then
            TextBox1.Text = "A grove of burned trees. Characters searching
the area and succeeding on a DC 10 Wisdom
(Survival) check find gnoll tracks. Following the
tracks for 1 d4 hours leads to an encounter with
gnolls, or the discovery of dead gnolls with elven
arrows sticking out of their flea-ridden corpses. "
        ElseIf random = 6 Then
            TextBox1.Text = "1 giant owl "
        ElseIf random = 7 Then
            TextBox1.Text = "An ivy-covered statue of an elven deity or hero. "
        ElseIf random = 8 Then
            TextBox1.Text = "1 dryad (50%) or 1d4 satyrs (50%) "
        ElseIf random = 9 Then
            TextBox1.Text = "1 d4 centaurs "
        ElseIf random = 10 Then
            TextBox1.Text = "2d4 scouts (elves). One scout carries a horn
and can use its action to blow it. If the horn is
blown within the forest, roll on this table again.
If the result indicates a monster encounter, the
indicated monster or monsters arrive in 1d4
minutes. New arrivals other than gnolls, hyenas,
owl bears, and displacer beasts are friendly
toward the scouts."
        ElseIf random = 11 Then
            TextBox1.Text = "2d4 pixies (50%) or 2d4 sprites (50%) "
        ElseIf random = 12 Then
            TextBox1.Text = "1 owlbear"
        ElseIf random = 13 Then
            TextBox1.Text = "1d4 elks (75%) or 1 giant elk (25%)"
        ElseIf random = 14 Then
            TextBox1.Text = "1d4 blink dogs"
        ElseIf random = 15 Then
            TextBox1.Text = "A magical plant with 2d4 glowing berries. A
creature that ingests a berry becomes invisible
for 1 hour, or until it attacks or casts a spell.
Once picked, a berry loses its magic after
12 hours. Berries regrow at midnight, but if
all its berries are picked , the plant becomes
nonmagical and grows no more berries. "
        ElseIf random = 16 Then
            TextBox1.Text = "An elven tune carried on a gentle breeze"
        ElseIf random = 17 Then
            TextBox1.Text = "1d4 orange (75%) or blue (25%) faerie dragons "
        ElseIf random = 18 Then
            TextBox1.Text = "1 druid (elf). The druid is initially indifferent
toward the party but becomes friendly if the
characters agree to rid the forest of its gnoll
infestation. "
        ElseIf random = 19 Then
            TextBox1.Text = "1 treant. The treant is friendly if the party
includes one or more elves or is accompanied by
a visible fey creature. The treant is hostile if the
characters are carrying open flames. Otherwise,
it is indifferent and doesn 't announce its
presence as the characters pass by. "
        ElseIf random = 20 Then
            TextBox1.Text = "1 unicorn "
        End If
        TextBox2.Text = random
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim testDie As New Random
        Dim random As Integer = testDie.Next(1, 7)
        Dim random2 As Integer = testDie.Next(1, 7)
        If random = 1 Then
            TextBox1.Text = "High Ability: Strength-powerful, brawny, strong as an ox "
        ElseIf random = 2 Then
            TextBox1.Text = "High Ability: Dexterity-lithe, agile, graceful "
        ElseIf random = 3 Then
            TextBox1.Text = "High Ability: Constitution-hardy, hale, healthy "
        ElseIf random = 4 Then
            TextBox1.Text = "High Ability: Intelligence-studious, learned, inquisitive "
        ElseIf random = 5 Then
            TextBox1.Text = "High Ability: Wisdom-perceptive, spiritual, insightful "
        ElseIf random = 6 Then
            TextBox1.Text = "High Ability: Charisma-persuasive, forceful, born leader "
        End If
        If random2 = 1 Then
            TextBox1.Text = TextBox1.Text + Environment.NewLine + "Low Ability: Strength-feeble, scrawny"
        ElseIf random2 = 2 Then
            TextBox1.Text = TextBox1.Text + Environment.NewLine + "Low Ability: Dexterity-clumsy, fumbling "
        ElseIf random2 = 3 Then
            TextBox1.Text = TextBox1.Text + Environment.NewLine + "Low Ability: Constitution-sickly, pale "
        ElseIf random2 = 4 Then
            TextBox1.Text = TextBox1.Text + Environment.NewLine + "Low Ability: Intelligence-dim-witted, slow "
        ElseIf random2 = 5 Then
            TextBox1.Text = TextBox1.Text + Environment.NewLine + "Low Ability: Wisdom - oblivious, absentminded"
        ElseIf random2 = 6 Then
            TextBox1.Text = TextBox1.Text + Environment.NewLine + "Low Ability: Charisma-dull, boring"
        End If
        TextBox2.Text = random & "," & random2
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim testDie As New Random
        Dim random As Integer = testDie.Next(1, 21)
        If random = 1 Then
            TextBox1.Text = "Distinctive jewelry: earrings, necklace, circlet,
bracelets "
        ElseIf random = 2 Then
            TextBox1.Text = "Piercings "
        ElseIf random = 3 Then
            TextBox1.Text = "Flamboyant or outlandish clothes "
        ElseIf random = 4 Then
            TextBox1.Text = "Formal, clean clothes "
        ElseIf random = 5 Then
            TextBox1.Text = "Ragged, dirty clothes "
        ElseIf random = 6 Then
            TextBox1.Text = "Pronounced scar "
        ElseIf random = 7 Then
            TextBox1.Text = "Missing teeth "
        ElseIf random = 8 Then
            TextBox1.Text = "Missing fingers "
        ElseIf random = 9 Then
            TextBox1.Text = "Unusual eye color (or two different colors) "
        ElseIf random = 10 Then
            TextBox1.Text = "Tattoos "
        ElseIf random = 11 Then
            TextBox1.Text = "Birthmark "
        ElseIf random = 12 Then
            TextBox1.Text = "Unusual skin color"
        ElseIf random = 13 Then
            TextBox1.Text = "Bald "
        ElseIf random = 14 Then
            TextBox1.Text = "Braided beard or hair"
        ElseIf random = 15 Then
            TextBox1.Text = "Unusual hair color "
        ElseIf random = 16 Then
            TextBox1.Text = "Nervous eye twitch "
        ElseIf random = 17 Then
            TextBox1.Text = "Distinctive nose "
        ElseIf random = 18 Then
            TextBox1.Text = "Distinctive posture (crooked or rigid) "
        ElseIf random = 19 Then
            TextBox1.Text = "Exceptionally beautiful "
        ElseIf random = 20 Then
            TextBox1.Text = "Exceptionally ugly "
        End If
        TextBox2.Text = random
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim testDie As New Random
        Dim random As Integer = testDie.Next(1, 21)
        If random = 1 Then
            TextBox1.Text = "Plays a musical instrument "
        ElseIf random = 2 Then
            TextBox1.Text = "Speaks several languages fluently"
        ElseIf random = 3 Then
            TextBox1.Text = "Unbelievably lucky "
        ElseIf random = 4 Then
            TextBox1.Text = "Perfect memory "
        ElseIf random = 5 Then
            TextBox1.Text = "Great with animals "
        ElseIf random = 6 Then
            TextBox1.Text = "Great with children "
        ElseIf random = 7 Then
            TextBox1.Text = "Great at solving puzzles"
        ElseIf random = 8 Then
            TextBox1.Text = "Great at one game "
        ElseIf random = 9 Then
            TextBox1.Text = "Great at impersonations "
        ElseIf random = 10 Then
            TextBox1.Text = "Draws beautifully "
        ElseIf random = 11 Then
            TextBox1.Text = "Paints beautifully "
        ElseIf random = 12 Then
            TextBox1.Text = "Sings beautifully"
        ElseIf random = 13 Then
            TextBox1.Text = "Drinks everyone under the table "
        ElseIf random = 14 Then
            TextBox1.Text = "Expert carpenter "
        ElseIf random = 15 Then
            TextBox1.Text = "Expert cook "
        ElseIf random = 16 Then
            TextBox1.Text = "Expert dart thrower and rock skipper "
        ElseIf random = 17 Then
            TextBox1.Text = "Expert juggler "
        ElseIf random = 18 Then
            TextBox1.Text = "Skilled actor and master of disguise "
        ElseIf random = 19 Then
            TextBox1.Text = "Skilled dancer "
        ElseIf random = 20 Then
            TextBox1.Text = "Knows thieves' cant "
        End If
        TextBox2.Text = random
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim testDie As New Random
        Dim random As Integer = testDie.Next(1, 13)
        If random = 1 Then
            TextBox1.Text = "Argumentative"
        ElseIf random = 2 Then
            TextBox1.Text = "Arrogant"
        ElseIf random = 3 Then
            TextBox1.Text = "Blustering"
        ElseIf random = 4 Then
            TextBox1.Text = "Rude"
        ElseIf random = 5 Then
            TextBox1.Text = "Curious"
        ElseIf random = 6 Then
            TextBox1.Text = "Friendly"
        ElseIf random = 7 Then
            TextBox1.Text = "Honest"
        ElseIf random = 8 Then
            TextBox1.Text = "Hot Tempered"
        ElseIf random = 9 Then
            TextBox1.Text = "Irritable"
        ElseIf random = 10 Then
            TextBox1.Text = "Ponderous"
        ElseIf random = 11 Then
            TextBox1.Text = "Quiet"
        ElseIf random = 12 Then
            TextBox1.Text = "Suspicious"
        End If
        TextBox2.Text = random
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim testDie As New Random
        Dim random As Integer = testDie.Next(1, 21)
        If random = 1 Then
            TextBox1.Text = "Prone to singing, whistling, or humming quietly"
        ElseIf random = 2 Then
            TextBox1.Text = "Speaks in rhyme or some other peculiar way"
        ElseIf random = 3 Then
            TextBox1.Text = "Particularly low or high voice "
        ElseIf random = 4 Then
            TextBox1.Text = "Slurs words, lisps, or stutters "
        ElseIf random = 5 Then
            TextBox1.Text = "Enunciates overly clearly "
        ElseIf random = 6 Then
            TextBox1.Text = "Speaks loudly "
        ElseIf random = 7 Then
            TextBox1.Text = "Whispers "
        ElseIf random = 8 Then
            TextBox1.Text = "Uses flowery speech or long words "
        ElseIf random = 9 Then
            TextBox1.Text = "Frequently uses the wrong word "
        ElseIf random = 10 Then
            TextBox1.Text = "Uses colorful oaths and exclamations "
        ElseIf random = 11 Then
            TextBox1.Text = "Makes constant jokes or puns "
        ElseIf random = 12 Then
            TextBox1.Text = "Prone to predictions of doom "
        ElseIf random = 13 Then
            TextBox1.Text = "Fidgets "
        ElseIf random = 14 Then
            TextBox1.Text = "Squints "
        ElseIf random = 15 Then
            TextBox1.Text = "Stares into the distance "
        ElseIf random = 16 Then
            TextBox1.Text = "Chews something "
        ElseIf random = 17 Then
            TextBox1.Text = "Paces "
        ElseIf random = 18 Then
            TextBox1.Text = "Taps fingers "
        ElseIf random = 19 Then
            TextBox1.Text = "Bites fingernails"
        ElseIf random = 20 Then
            TextBox1.Text = "Twirls hair or tugs beard "
        End If
        TextBox2.Text = random
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim testDie As New Random
        Dim random As Integer = testDie.Next(1, 7)
        If random = 1 Then
            TextBox1.Text = "Good: Beauty       Evil: Domination" + Environment.NewLine + "Lawful: Community     Chaotic: Change" + Environment.NewLine + "Neutral: Balance      Other: Aspiration"
        ElseIf random = 2 Then
            TextBox1.Text = "Good: Charity       Evil: Greed" + Environment.NewLine + "Lawful: Fairness     Chaotic: Creativity" + Environment.NewLine + "Neutral: Knowledge      Other: Discovery"
        ElseIf random = 3 Then
            TextBox1.Text = "Good: Greater Good       Evil: Might" + Environment.NewLine + "Lawful: Honor     Chaotic: Freedom" + Environment.NewLine + "Neutral: Live and let live      Other: Glory"
        ElseIf random = 4 Then
            TextBox1.Text = "Good: Life      Evil: Pain" + Environment.NewLine + "Lawful: Logic     Chaotic: Independence" + Environment.NewLine + "Neutral: Moderation      Other: Nation"
        ElseIf random = 5 Then
            TextBox1.Text = "Good: Respect       Evil: Retribution" + Environment.NewLine + "Lawful: Responsibility     Chaotic: No limits" + Environment.NewLine + "Neutral: Neutrality      Other: Redeption"
        ElseIf random = 6 Then
            TextBox1.Text = "Good: Self-sacrifice       Evil: Slaughter" + Environment.NewLine + "Lawful: Tradition     Chaotic: Whimsy" + Environment.NewLine + "Neutral: People      Other: Self-knowledge"
        End If
        TextBox2.Text = random
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim testDie As New Random
        Dim random As Integer = testDie.Next(1, 11)
        If random = 1 Then
            TextBox1.Text = "Dedicated to fulfilling a personal life goal"
        ElseIf random = 2 Then
            TextBox1.Text = "Protective of close family members "
        ElseIf random = 3 Then
            TextBox1.Text = "Protective of colleagues or compatriots "
        ElseIf random = 4 Then
            TextBox1.Text = "Loyal to a benefactor, patron, or employer "
        ElseIf random = 5 Then
            TextBox1.Text = "Captivated by a romantic interest"
        ElseIf random = 6 Then
            TextBox1.Text = "Drawn to a special place"
        ElseIf random = 7 Then
            TextBox1.Text = "Protective of a sentimental keepsake "
        ElseIf random = 8 Then
            TextBox1.Text = "Protective of a valuable possession "
        ElseIf random = 9 Then
            TextBox1.Text = "Out for revenge "
        ElseIf random = 10 Then
            TextBox1.Text = "Roll twice, ignoring results of10 "
        End If
        TextBox2.Text = random
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim testDie As New Random
        Dim random As Integer = testDie.Next(1, 13)
        If random = 1 Then
            TextBox1.Text = "Forbidden love or susceptibility to romance"
        ElseIf random = 2 Then
            TextBox1.Text = "Enjoys decadent pleasures"
        ElseIf random = 3 Then
            TextBox1.Text = "Arrogance"
        ElseIf random = 4 Then
            TextBox1.Text = "Envies another creature's possessions or station "
        ElseIf random = 5 Then
            TextBox1.Text = "Overpowering greed "
        ElseIf random = 6 Then
            TextBox1.Text = "Prone to rage "
        ElseIf random = 7 Then
            TextBox1.Text = "Has a powerful enemy "
        ElseIf random = 8 Then
            TextBox1.Text = "Specific phobia"
        ElseIf random = 9 Then
            TextBox1.Text = "Shameful or scandalous history"
        ElseIf random = 10 Then
            TextBox1.Text = "Secret crime or misdeed "
        ElseIf random = 11 Then
            TextBox1.Text = "Possession offorbidden lore"
        ElseIf random = 12 Then
            TextBox1.Text = "Foolhardy bravery "
        End If
        TextBox2.Text = random
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim testDie As New Random
        Dim valHold As Integer
        Dim random As Integer = testDie.Next(1, 9)
        If random = 1 Then
            Dim random2 As Integer = testDie.Next(1, 5)
            valHold = random2
            If random2 = 1 Then
                TextBox1.Text = "Immortality: " + "Acquire a legendary item to prolong life "
            ElseIf random2 = 2 Then
                TextBox1.Text = "Immortality: " + "Ascend to godhood "
            ElseIf random2 = 3 Then
                TextBox1.Text = "Immortality: " + "Become undead or obtain a younger body "
            ElseIf random2 = 4 Then
                TextBox1.Text = "Immortality: " + "Steal a planar creature's essence "
            End If
        ElseIf random = 2 Then
            Dim random2 As Integer = testDie.Next(1, 5)
            valHold = random2
            If random2 = 1 Then
                TextBox1.Text = "Influence: " + "Seize a position of power or title "
            ElseIf random2 = 2 Then
                TextBox1.Text = "Influence: " + "Win a contest or tournament "
            ElseIf random2 = 3 Then
                TextBox1.Text = "Influence: " + "Win favor with a powerful individual "
            ElseIf random2 = 4 Then
                TextBox1.Text = "Influence: " + "Place a pawn in a position of power"
            End If
        ElseIf random = 3 Then
            Dim random2 As Integer = testDie.Next(1, 7)
            valHold = random2
            If random2 = 1 Then
                TextBox1.Text = "Magic: " + "Obtain an ancient artifact "
            ElseIf random2 = 2 Then
                TextBox1.Text = "Magic: " + "Build a construct or magical device "
            ElseIf random2 = 3 Then
                TextBox1.Text = "Magic: " + "Carry out a deity's wishes "
            ElseIf random2 = 4 Then
                TextBox1.Text = "Magic: " + "Offer sacrifices to a deity "
            ElseIf random2 = 5 Then
                TextBox1.Text = "Magic: " + "Contact a lost deity or power "
            ElseIf random2 = 6 Then
                TextBox1.Text = "Magic: " + "Open a gate to another world "
            End If
        ElseIf random = 4 Then
            Dim random2 As Integer = testDie.Next(1, 7)
            valHold = random2
            If random2 = 1 Then
                TextBox1.Text = "Mayhem: " + "Fulfill an apocalyptic prophecy "
            ElseIf random2 = 2 Then
                TextBox1.Text = "Mayhem: " + "Enact the vengeful will of a god or patron "
            ElseIf random2 = 3 Then
                TextBox1.Text = "Mayhem: " + "Spread a vile contagion "
            ElseIf random2 = 4 Then
                TextBox1.Text = "Mayhem: " + "Overthrow a government"
            ElseIf random2 = 5 Then
                TextBox1.Text = "Mayhem: " + "Trigger a natural disaster"
            ElseIf random2 = 6 Then
                TextBox1.Text = "Mayhem: " + "Utterly destroy a bloodline or clan"
            End If
        ElseIf random = 5 Then
            Dim random2 As Integer = testDie.Next(1, 5)
            valHold = random2
            If random2 = 1 Then
                TextBox1.Text = "Passion: " + "Prolong the life of a loved one"
            ElseIf random2 = 2 Then
                TextBox1.Text = "Passion: " + "Prove worthy of another person's love "
            ElseIf random2 = 3 Then
                TextBox1.Text = "Passion: " + "Raise or restore a dead loved one "
            ElseIf random2 = 4 Then
                TextBox1.Text = "Passion: " + "Destroy rivals for another person's affection"
            End If
        ElseIf random = 6 Then
            Dim random2 As Integer = testDie.Next(1, 5)
            valHold = random2
            If random2 = 1 Then
                TextBox1.Text = "Power: " + "Conquer a region or incite a rebellion"
            ElseIf random2 = 2 Then
                TextBox1.Text = "Power: " + "Seize control of an army"
            ElseIf random2 = 3 Then
                TextBox1.Text = "Power: " + "Become the power behind the throne "
            ElseIf random2 = 4 Then
                TextBox1.Text = "Power: " + "Gain the favor of a ruler "
            End If
        ElseIf random = 7 Then
            Dim random2 As Integer = testDie.Next(1, 5)
            valHold = random2
            If random2 = 1 Then
                TextBox1.Text = "Revenge: " + "Avenge a past humiliation or insult"
            ElseIf random2 = 2 Then
                TextBox1.Text = "Revenge: " + "Avenge a past imprisonment or injury"
            ElseIf random2 = 3 Then
                TextBox1.Text = "Revenge: " + "Avenge the death of a loved one "
            ElseIf random2 = 4 Then
                TextBox1.Text = "Revenge: " + "Retrieve stolen property and punish the thief"
            End If
        ElseIf random = 8 Then
            Dim random2 As Integer = testDie.Next(1, 5)
            valHold = random2
            If random2 = 1 Then
                TextBox1.Text = "Wealth: " + "Control natural resources or trade "
            ElseIf random2 = 2 Then
                TextBox1.Text = "Wealth: " + "Marry into wealth "
            ElseIf random2 = 3 Then
                TextBox1.Text = "Wealth: " + "Plunder ancient ruins "
            ElseIf random2 = 4 Then
                TextBox1.Text = "Wealth: " + "Steal land, goods, or money "
            End If
        End If
        TextBox2.Text = random & "," & valHold
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim testDie As New Random
        Dim valHold As Integer
        Dim random As Integer = testDie.Next(1, 9)
        valHold = 0
        If random = 1 Then
            Dim random2 As Integer = testDie.Next(1, 5)
            valHold = random2
            If random2 = 1 Then
                TextBox1.Text = "Agricultural Devastation: " + "Blight"
            ElseIf random2 = 2 Then
                TextBox1.Text = "Agricultural Devastation: " + "Crop Failure"
            ElseIf random2 = 3 Then
                TextBox1.Text = "Agricultural Devastation: " + "Drought"
            ElseIf random2 = 4 Then
                TextBox1.Text = "Agricultural Devastation: " + "Famine"
            End If
        ElseIf random = 2 Then
            TextBox1.Text = "Assault or Beatings"
        ElseIf random = 3 Then
            TextBox1.Text = "Bounty hunting or assasination"
        ElseIf random = 4 Then
            Dim random2 As Integer = testDie.Next(1, 11)
            valHold = random2
            If random2 = 1 Then
                TextBox1.Text = "Captivity or coercion: " + "Bribery"
            ElseIf random2 = 2 Then
                TextBox1.Text = "Captivity or coercion: " + "Enticement"
            ElseIf random2 = 3 Then
                TextBox1.Text = "Captivity or coercion: " + "Eviction"
            ElseIf random2 = 4 Then
                TextBox1.Text = "Captivity or coercion: " + "Imprisonment"
            ElseIf random2 = 5 Then
                TextBox1.Text = "Captivity or coercion: " + "Kidnapping"
            ElseIf random2 = 6 Then
                TextBox1.Text = "Captivity or coercion: " + "Legal intimidation"
            ElseIf random2 = 7 Then
                TextBox1.Text = "Captivity or coercion: " + "Press gangs"
            ElseIf random2 = 8 Then
                TextBox1.Text = "Captivity or coercion: " + "Shackling"
            ElseIf random2 = 9 Then
                TextBox1.Text = "Captivity or coercion: " + "Slavery"
            ElseIf random2 = 10 Then
                TextBox1.Text = "Captivity or coercion: " + "Threats or harassment"
            End If
        ElseIf random = 5 Then
            Dim random2 As Integer = testDie.Next(1, 7)
            valHold = random2
            If random2 = 1 Then
                TextBox1.Text = "Confidence scams: " + "Breach of contract"
            ElseIf random2 = 2 Then
                TextBox1.Text = "Confidence scams: " + "Cheating"
            ElseIf random2 = 3 Then
                TextBox1.Text = "Confidence scams: " + "Fast talking"
            ElseIf random2 = 4 Then
                TextBox1.Text = "Confidence scams: " + "Fine print"
            ElseIf random2 = 5 Then
                TextBox1.Text = "Confidence scams: " + "Fraud or swindling"
            ElseIf random2 = 6 Then
                TextBox1.Text = "Confidence scams: " + "Quackery or tricks"
            End If
        ElseIf random = 6 Then
            Dim random2 As Integer = testDie.Next(1, 5)
            valHold = random2
            If random2 = 1 Then
                TextBox1.Text = "Defamation: " + "Framing"
            ElseIf random2 = 2 Then
                TextBox1.Text = "Defamation: " + "Gossiping or slander"
            ElseIf random2 = 3 Then
                TextBox1.Text = "Defamation: " + "Humiliation"
            ElseIf random2 = 4 Then
                TextBox1.Text = "Defamation: " + "Libel or insults"
            End If
        ElseIf random = 7 Then
            TextBox1.Text = "Dueling"
        ElseIf random = 8 Then
            Dim random2 As Integer = testDie.Next(1, 9)
            valHold = random2
            If random2 = 1 Then
                TextBox1.Text = "Execution: " + "Beheading"
            ElseIf random2 = 2 Then
                TextBox1.Text = "Execution: " + "Burning at the stake"
            ElseIf random2 = 3 Then
                TextBox1.Text = "Execution: " + "Burying alive"
            ElseIf random2 = 4 Then
                TextBox1.Text = "Execution: " + "Crucifixion"
            ElseIf random2 = 5 Then
                TextBox1.Text = "Execution: " + "Drawing and quartering"
            ElseIf random2 = 6 Then
                TextBox1.Text = "Execution: " + "Hanging"
            ElseIf random2 = 7 Then
                TextBox1.Text = "Execution: " + "Impalement"
            ElseIf random2 = 8 Then
                TextBox1.Text = "Execution: " + "Sacrifice (living)"
            End If
        ElseIf random = 9 Then
            TextBox1.Text = "Impersonation or disguise"
        ElseIf random = 10 Then
            TextBox1.Text = "Lying or perjury"
        ElseIf random = 11 Then
            Dim random2 As Integer = testDie.Next(1, 9)
            valHold = random2
            If random2 = 1 Then
                TextBox1.Text = "Magical Mayhem: " + "Hauntings"
            ElseIf random2 = 2 Then
                TextBox1.Text = "Magical Mayhem: " + "Illusions"
            ElseIf random2 = 3 Then
                TextBox1.Text = "Magical Mayhem: " + "Infernal bargains"
            ElseIf random2 = 4 Then
                TextBox1.Text = "Magical Mayhem: " + "Mind control"
            ElseIf random2 = 5 Then
                TextBox1.Text = "Magical Mayhem: " + "Petrification"
            ElseIf random2 = 6 Then
                TextBox1.Text = "Magical Mayhem: " + "Raising or animating the dead"
            ElseIf random2 = 7 Then
                TextBox1.Text = "Magical Mayhem: " + "Summoning monsters"
            ElseIf random2 = 8 Then
                TextBox1.Text = "Magical Mayhem: " + "Weather control"
            End If
        ElseIf random = 12 Then
            Dim random2 As Integer = testDie.Next(1, 11)
            valHold = random2
            If random2 = 1 Then
                TextBox1.Text = "Murder: " + "Assassination "
            ElseIf random2 = 2 Then
                TextBox1.Text = "Murder: " + "Cannibalism"
            ElseIf random2 = 3 Then
                TextBox1.Text = "Murder: " + "Dismemberment "
            ElseIf random2 = 4 Then
                TextBox1.Text = "Murder: " + "Drowning"
            ElseIf random2 = 5 Then
                TextBox1.Text = "Murder: " + "Electrocution "
            ElseIf random2 = 6 Then
                TextBox1.Text = "Murder: " + "Euthanasia (involuntary)"
            ElseIf random2 = 7 Then
                TextBox1.Text = "Murder: " + "Disease"
            ElseIf random2 = 8 Then
                TextBox1.Text = "Murder: " + "Poisoning "
            ElseIf random2 = 9 Then
                TextBox1.Text = "Murder: " + "Stabbing "
            ElseIf random2 = 10 Then
                TextBox1.Text = "Murder: " + "Strangulation or suffocation "
            End If
        ElseIf random = 13 Then
            TextBox1.Text = "Neglect"
        ElseIf random = 14 Then
            Dim random2 As Integer = testDie.Next(1, 7)
            valHold = random2
            If random2 = 1 Then
                TextBox1.Text = "Politics: " + "Betrayal or treason"
            ElseIf random2 = 2 Then
                TextBox1.Text = "Politics: " + "Conspiracy "
            ElseIf random2 = 3 Then
                TextBox1.Text = "Politics: " + "Espionage or spying "
            ElseIf random2 = 4 Then
                TextBox1.Text = "Politics: " + "Genocide "
            ElseIf random2 = 5 Then
                TextBox1.Text = "Politics: " + "Oppression"
            ElseIf random2 = 6 Then
                TextBox1.Text = "Politics: " + "Raising taxes "
            End If
        ElseIf random = 15 Then
            Dim random2 As Integer = testDie.Next(1, 5)
            valHold = random2
            If random2 = 1 Then
                TextBox1.Text = "Religion: " + "Curses"
            ElseIf random2 = 2 Then
                TextBox1.Text = "Religion: " + "Desecration"
            ElseIf random2 = 3 Then
                TextBox1.Text = "Religion: " + "False gods"
            ElseIf random2 = 4 Then
                TextBox1.Text = "Religion: " + "Heresy or cults"
            End If
        ElseIf random = 16 Then
            TextBox1.Text = "Stalking"
        ElseIf random = 17 Then
            Dim random2 As Integer = testDie.Next(1, 11)
            valHold = random2
            If random2 = 1 Then
                TextBox1.Text = "Theft or Property Crime: " + "Arson"
            ElseIf random2 = 2 Then
                TextBox1.Text = "Theft or Property Crime: " + "Blackmail or extortion "
            ElseIf random2 = 3 Then
                TextBox1.Text = "Theft or Property Crime: " + "Burglary"
            ElseIf random2 = 4 Then
                TextBox1.Text = "Theft or Property Crime: " + "Counterfeiting "
            ElseIf random2 = 5 Then
                TextBox1.Text = "Theft or Property Crime: " + "Highway robbery"
            ElseIf random2 = 6 Then
                TextBox1.Text = "Theft or Property Crime: " + "Looting "
            ElseIf random2 = 7 Then
                TextBox1.Text = "Theft or Property Crime: " + "Mugging "
            ElseIf random2 = 8 Then
                TextBox1.Text = "Theft or Property Crime: " + "Poaching"
            ElseIf random2 = 9 Then
                TextBox1.Text = "Theft or Property Crime: " + "Seizing property"
            ElseIf random2 = 10 Then
                TextBox1.Text = "Theft or Property Crime: " + "Smuggling "
            End If
        ElseIf random = 18 Then
            Dim random2 As Integer = testDie.Next(1, 7)
            valHold = random2
            If random2 = 1 Then
                TextBox1.Text = "Torture: " + "Acid"
            ElseIf random2 = 2 Then
                TextBox1.Text = "Torture: " + "Blinding"
            ElseIf random2 = 3 Then
                TextBox1.Text = "Torture: " + "Branding"
            ElseIf random2 = 4 Then
                TextBox1.Text = "Torture: " + "Racking"
            ElseIf random2 = 5 Then
                TextBox1.Text = "Torture: " + "Thumbscrews "
            ElseIf random2 = 6 Then
                TextBox1.Text = "Torture: " + "Whipping "
            End If
        ElseIf random = 19 Then
            Dim random2 As Integer = testDie.Next(1, 5)
            valHold = random2
            If random2 = 1 Then
                TextBox1.Text = "Vice: " + "Adultery"
            ElseIf random2 = 2 Then
                TextBox1.Text = "Vice: " + "Drugs or alcohol "
            ElseIf random2 = 3 Then
                TextBox1.Text = "Vice: " + "Gambling"
            ElseIf random2 = 4 Then
                TextBox1.Text = "Vice: " + "Seduction"
            End If
        ElseIf random = 20 Then
            Dim random2 As Integer = testDie.Next(1, 7)
            valHold = random2
            If random2 = 1 Then
                TextBox1.Text = "Warfare: " + "Ambush "
            ElseIf random2 = 2 Then
                TextBox1.Text = "Warfare: " + "Invasion"
            ElseIf random2 = 3 Then
                TextBox1.Text = "Warfare: " + "Massacre "
            ElseIf random2 = 4 Then
                TextBox1.Text = "Warfare: " + "Mercenaries  "
            ElseIf random2 = 5 Then
                TextBox1.Text = "Warfare: " + "Rebellion "
            ElseIf random2 = 6 Then
                TextBox1.Text = "Warfare: " + "Terrorism "
            End If
        End If
        TextBox2.Text = random & "," & valHold
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Dim testDie As New Random
        Dim random As Integer = testDie.Next(1, 9)
        If random = 1 Then
            TextBox1.Text = "A hidden object holds the villain's soul. "
        ElseIf random = 2 Then
            TextBox1.Text = "The villain's power is broken if the# death of its true 
love is avenged. "
        ElseIf random = 3 Then
            TextBox1.Text = "The villain is weakened in the presence of a 
particular artifact. "
        ElseIf random = 4 Then
            TextBox1.Text = "A special weapon deals extra damage when used 
against the villain."
        ElseIf random = 5 Then
            TextBox1.Text = "The villain is destroyed if it speaks its true name. "
        ElseIf random = 6 Then
            TextBox1.Text = "An ancient prophecy or riddle reveals how the 
villain can be overthrown. "
        ElseIf random = 7 Then
            TextBox1.Text = "The villain falls when an ancient enemy forgives its 
past actions. "
        ElseIf random = 8 Then
            TextBox1.Text = "The villain loses its power if a mystic bargain it struck long ago is completed. "
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