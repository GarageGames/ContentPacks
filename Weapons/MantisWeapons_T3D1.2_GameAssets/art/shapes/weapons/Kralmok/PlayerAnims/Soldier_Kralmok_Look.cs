singleton TSShapeConstructor(Soldier_Kralmok_LookDAE)
{
   baseShape = "./Soldier_Kralmok_Look.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kralmok_LookDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Look", "820", "830", true, true);
}
