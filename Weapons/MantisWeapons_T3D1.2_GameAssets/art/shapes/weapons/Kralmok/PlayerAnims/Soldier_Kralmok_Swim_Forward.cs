singleton TSShapeConstructor(Soldier_Kralmok_Swim_ForwardDAE)
{
   baseShape = "./Soldier_Kralmok_Swim_Forward.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kralmok_Swim_ForwardDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Forward", "1360", "1419", true, true);
}
