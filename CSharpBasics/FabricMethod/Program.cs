using FabricMethod;

Developer developer = new PanelDeveloper();
House house = developer.Create();
house.GetHouse();

developer = new WoodDeveloper();
house = developer.Create();
house.GetHouse();