singleton TSShapeConstructor(Soldier_Kralmok_LandDAE)
{
   baseShape = "./Soldier_Kralmok_Land.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kralmok_LandDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Land", "1005", "1020", true, true);
}
