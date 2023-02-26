# doggyMan_demo1

1. translate.Translate(X,Y,Z)
2. SerializeField
    1. appear in the inspector
3. keyboard input 
    - accessed from project setting→input manager→horizontal or something u want
    - Input.GetAxis(’Horizontal’)
4. time.DeltaTime
    
    *tells how long the time take the computer to execute the command 
    
5. Cinemachine 
    - [intro] enable mutiple camera for providing the need of mutiple perspectives
    - 
    - [cameraBrain] the way used to control the movement of the camera
        - [priority] create a virtual camera object from [Cinemachine] table at the top menu bar
        - [Framing Transposer]: used to make sure the object is in the scaled frame
        - [follow] target with a  object, so that the Virtual camera would follow the object
    1. get and post(access adn upadate) the component
        
        GetCompoennt<component_name>().property1.subproperty2… = something youwant
        
    2. Time.time
        - the amount of time passed since the games started to play
    3. onCollisionEnter()
        
        ```csharp
        private void OncollisionEnter(Collision other){
        	//here it means if the 	gameobject triggers the Collision event"other"
        	// and if it's name(we use tag) is 'player' ,we do theres things
        if(other.gameObject.tag == "player"){ 
        		//do soemthing
        	gameObject.tag = 'hit';
        	//above code it means the current's(current object's tag/name) is changed to be 'hit'
        }
        }
        ```
        
    4. structure of the Assets
        1. Prefab
            - storing the complete gameobejct(cs file, material and etc) into it, easier to use next time
        2. Scripts
        3. Scenes