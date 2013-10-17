singleton TSShapeConstructor(Soldier_Kral_Swim_ForwardDAE)
{
   baseShape = "./Soldier_Kral_Swim_Forward.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kral_Swim_ForwardDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Forward", "1510", "1569", true, true);
}
