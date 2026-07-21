# Install 

## Stalin

### 17 July 2026

I put Stalin in a single room with one door for now (partly to test out prefabbing my spaces and carefully baking area lighting etc.) I made him very big, turned him into a rigidbody and dropped him on his face so that he's kind of abjectly face down and huge in a small room.

![](./images/process-screenshots/Screenshot%202026-07-17%20at%2010.46.03.png)

Wondering if, given there's only the one door, he should be even bigger, taking up the whole volume so that he's simultaneous huge and powerful and trapped and sad and in a sense has had his head ripped off (because he's a bust). Unsure for now... there's something *very slightly underwhelming* going on here and I'm not too sure what it is, but it could just be the totally decontextualized thing of this test? Like, if you walked into this room from the context of another room his scale and so on would presumably be more interesting.

I also wonder about having no lighting at all or really minimal lighting so he's just alone in the dark. Am I being too heavy handed with all this? But maybe if he were more mysterious and dark it would be more interesting as well, just a bit of gleaming in the dark, a silhouette etc. It's all in the lighting probably!

### 20 July 2026

Made Stalin as big as he can be while still fiting into the room (diagonally). I think it's kind of good enough for now, though will need a serious revisit.

## Pizza

### 20 July 2026

Installed the pizza in a standard smallest square room but it was too big for a single pizza maxing out one hanging area on the wall facing the door. So made an even smaller room, the smaller possible in fact, and am trying that out. My instinct is that it's kind of good. Might want some velvet ropes around the pizza?

![](./images/process-screenshots/Screenshot%202026-07-20%20at%2014.14.59.png)

Put some in and it increases the aura of the thing I think? Should there be three pizzas across, like a triptych? Do I re-embrace the idea of the three formats (albeda, normal, nothing)? They would fit kind of perfectly and it would also fit with the idea of this being about PBR? I'll try it as it does seem rather important. Still kind of what the "best pizza" in the middle though so it might turn out we need the other walls for it? Ideally not as I like the single wall viewing feel.

## Pictures

### 20 July 2026

Took a first swing by very sensibly thinking prototype instead of final. So I made one (door containing) wall of the pictures kind of alternating but also scales to different dimensions (on X and Z) including not locking proportions so you get weird stretched versions on the vertical and horizontal specifically to fill space in a more interesting way. There's a useful illustration there both on the malleability and mistreatment of assets I think?

![](./images/process-screenshots/Screenshot%202026-07-20%20at%2014.41.09.png)

![](./images/process-screenshots/Screenshot%202026-07-20%20at%2014.46.45.png)

This room pretty clearly works. I don't think it needs the ropes. Could possible use a sofa in the middle. I'll pop one in, something to imply "sit and contemplate" is useful here and holds some space in the centre of the room. I think this room looks like it works.

## Spaceship

### 20 July 2026

For now I'm just throwing it in a room at its maximum fitting scale (it's huuuuuuge otherwise -- Maksim's approach to object scale doesn't always make a lot of sense to me?). It's might be better off a bit smaller to be able to get some distance, but for now I'll try this...

![](./images/process-screenshots/Screenshot%202026-07-20%20at%2015.21.32.png)

It sort of looks fine really. Especially as an earlier, less experimental thing it may make sense like this as I discussed somewhere. It's possible I should lean even harder into the idea of it just as a "model" and so it's scaled down more and behind ropes just as a thing to look at. Let me see that...

![](./images/process-screenshots/Screenshot%202026-07-20%20at%2015.28.36.png)

Yeah I think that's an improvement really. We'll stick with it for now.

## Base Man

My starting ploy is to make a big pile of them and see if that feels like something. I created a rag doll prefab of the guy and then superimposed 100 of them floating above the floor then hit play. They turned into an INCREDIBLE monster of flailing strange limbs that was frankly kind of freaky and just like a horror movie as the engine figured out how to resolve all the bad and fucked up physics involved. Eventually it subsided into a whole lot of base men lying on the floor and piled up and it looks... really kind of good. I'm lighting it right now so we will see. I'm tempted to try to pile them even higher if I can? Like if they could reach the ceiling that would be pretty amazing. I removed all the created rigidbodies and characterjoints so the point is they will just be static and therefore can be baked lighting and therefore can have pretty complex lighting (required by all that occlusion I suppose?) and yet not have it be computationally insane not take any more room particularly than lighting anything else? That's the idea...

![](./images/process-screenshots/Screenshot%202026-07-21%20at%2014.57.18.png)

![](./images/process-screenshots/Screenshot%202026-07-21%20at%2014.57.28.png)

Currently they are not lighting at all properly though which is annoying. We just have a very, very dark room. Looks good without the lighting turned on though which suggests this is worth it...

![](./images/process-screenshots/Screenshot%202026-07-21%20at%2015.02.37.png)

Hmm, well that's frustrating. Still not working. Will continue to look into this and figure it out. The basic visual effect other than the lighting is pretty strong so I do want to keep it this way if remotely possible. Trying it out with just One Man...

![](./images/process-screenshots/Screenshot%202026-07-21%20at%2015.11.55.png)

Maybe some luck here with a Light Probe Group? Seems to be helping the meshes see the light so to speak? Okay well it did the trick even with the big group so.... a win but suggests that there's something about the men (and their ragdolliness) that makes Unity unable to treat them as truly static (since a light probe group as I'm understanding it is about maintaining baked lighting effects for dynamic objects or something). Anyway it does work! SO. Carrying on.

![](./images/process-screenshots/Screenshot%202026-07-21%20at%2015.16.52.png)

![](./images/process-screenshots/Screenshot%202026-07-21%20at%2015.18.49.png)