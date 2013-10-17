singleton TSShapeConstructor(Soldier_Kral_LandDAE)
{
   baseShape = "./Soldier_Kral_Land.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kral_LandDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Land", "1080", "1095", true, true);
}
