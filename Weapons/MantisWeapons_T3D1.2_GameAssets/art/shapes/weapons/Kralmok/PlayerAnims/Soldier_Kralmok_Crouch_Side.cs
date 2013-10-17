singleton TSShapeConstructor(Soldier_Kralmok_Crouch_SideDAE)
{
   baseShape = "./Soldier_Kralmok_Crouch_Side.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kralmok_Crouch_SideDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Side", "500", "529", true, true);
}
