using Strategy;

Hero hero = new Hero("Hero");
hero.Attack();
hero.SetWeapon(new Gun());
hero.Attack();
hero.SetWeapon(new WaterGun());
hero.Attack();
